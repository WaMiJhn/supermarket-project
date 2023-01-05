using RhDalLibrary.DTO;
using RhDalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDalLibrary.DAL
{
	public class OrderDAL : BaseDAL, IOrderDAL
	{
		//create
		public int CreateOrder(DateTime date, int deliveryoptionid, int orderstatusid, int? customerid)
		{
			try
			{
				List<SqlParameter> spList = new List<SqlParameter> {
					new SqlParameter("@date", date),
					new SqlParameter("@deliveryoptionid", deliveryoptionid),
					new SqlParameter("@orderstatusid", orderstatusid) };
				if (customerid == null) { spList.Add(new SqlParameter("@customerid", DBNull.Value)); }
				else { spList.Add(new SqlParameter("@customerid", customerid)); }
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into orderTbl (OrderDate, DeliveryOptionId, OrderStatusId, CustomerId) " +
						"values (@date, @deliveryoptionid, @orderstatusid, @customerid); SELECT SCOPE_IDENTITY()", spList.ToArray());
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public bool CreateOrderLine(int orderid, int itemid, int quantity)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@orderid", orderid),
					new SqlParameter("@itemid", itemid),
					new SqlParameter("@quantity", quantity) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("insert into orderLineTbl (OrderId, ItemId, ItemQuantity) " +
						"values (@orderid, @itemid, @quantity)", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public int CreateHomeDelivery(DateTime deliverDateTime)
		{
			try
			{
				if (OpenConnection())
				{
					SqlCommand cmdDelivery = CreateCommand("insert into deliveryOptionTbl DEFAULT VALUES; SELECT SCOPE_IDENTITY()");
					int deliveryoptionid = Convert.ToInt32(cmdDelivery.ExecuteScalar());
					SqlParameter[] sp = new SqlParameter[] {
						new SqlParameter("@deliveryoptionid", deliveryoptionid),
						new SqlParameter("@deliverdatetime", deliverDateTime)};
					SqlCommand cmdHomeDelivery = CreateCommand("insert into homeDeliveryTbl (DeliveryOptionId, DeliverDateTime) " +
						"values (@deliveryoptionid, @deliverdatetime)", sp);
					cmdHomeDelivery.ExecuteNonQuery();
					return deliveryoptionid;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public int CreatePickupDelivery(string location, DateTime preferredTimeSlot)
		{
			try
			{
				if (OpenConnection())
				{
					SqlCommand cmdDelivery = CreateCommand("insert into deliveryOptionTbl DEFAULT VALUES; SELECT SCOPE_IDENTITY()");
					int deliveryoptionid = Convert.ToInt32(cmdDelivery.ExecuteScalar());
					SqlParameter[] sp = new SqlParameter[] {
						new SqlParameter("@deliveryoptionid", deliveryoptionid),
						new SqlParameter("@location", location),
						new SqlParameter("@preferredtimeslot", preferredTimeSlot) };
					SqlCommand cmdPickupDelivery = CreateCommand("insert into pickupDeliveryTbl (DeliveryOptionId, Location, PreferredTimeSlot) " +
						"values (@deliveryoptionid, @location, @preferredtimeslot)", sp);
					cmdPickupDelivery.ExecuteNonQuery();
					return deliveryoptionid;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		//read
		//public DataTable GetOrderDataTable(string search)
		//{
		//	try
		//	{
		//		DataTable dt = new DataTable();
		//		if (OpenConnection())
		//		{
		//			SqlCommand cmd = CreateCommand("select o.id, o.OrderDate, concat(p.FirstName, ' ', p.LastName) as FullName, os.StatusName " +
		//				"from orderTbl as o inner join customerTbl as c on o.CustomerId = c.CustomerId inner join " +
		//				"personTbl as p on c.CustomerId = p.id inner join orderStatusTbl as os on o.OrderStatusId = os.id " +
		//				"where o.id like '%" + search + "%' or concat(p.FirstName, ' ', p.LastName) like '%" + search + "%'");
		//			SqlDataAdapter adp = new SqlDataAdapter(cmd);
		//			adp.Fill(dt);
		//			return dt;
		//		}
		//		else { throw new Exception("Database connection could not be opened."); }
		//	}
		//	//catch (SqlException ex) { throw new Exception(ex.Message); }
		//	finally { CloseConnection(); }
		//}
		public DataTable GetOrderDataTable(string search)
		{
			try
			{
				DataTable dt = new DataTable();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select o.id, o.OrderDate, concat(p.FirstName, ' ', p.LastName) as FullName, os.StatusName " +
						"from orderTbl as o left outer join customerTbl as c on o.CustomerId = c.CustomerId left outer join " +
						"personTbl as p on c.CustomerId = p.id inner join orderStatusTbl as os on o.OrderStatusId = os.id " +
						"where o.id like '%" + search + "%' or concat(p.FirstName, ' ', p.LastName) like '%" + search + "%'");
					SqlDataAdapter adp = new SqlDataAdapter(cmd);
					adp.Fill(dt);
					return dt;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			//catch (SqlException ex) { throw new Exception(ex.Message); }
			finally { CloseConnection(); }
		}
		public OrderDTO FindOrder(int id)
		{
			try
			{
				OrderDTO found = null;
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@id", id) };
				if (OpenConnection())
				{
					//SqlCommand cmd = CreateCommand("select o.id, o.OrderDate,  " +
					//	"from orderTbl where id = @id", sp);
					SqlCommand cmd;
					SqlCommand cmdCheckDeliveryOption = CreateCommand("select count(*) from orderTbl as o " +
						"inner join deliveryOptionTbl as d on o.DeliveryOptionId = d.id " +
						"inner join homeDeliveryTbl as h on d.id = h.DeliveryOptionId where o.id = @id", sp);
					bool isHomeDelivery = Convert.ToInt32(cmdCheckDeliveryOption.ExecuteScalar()) == 1;
					if (isHomeDelivery)
					{
						cmd = CreateCommand("select o.id, o.OrderDate, h.DeliveryOptionId, h.DeliverDateTime, os.id as OrderStatusId, os.StatusName " +
							"from orderTbl as o inner join deliveryOptionTbl as d on o.DeliveryOptionId = d.id " +
							"inner join homeDeliveryTbl as h on d.id = h.DeliveryOptionId " +
							"inner join orderStatusTbl as os on os.id = o.OrderStatusId " +
							"where o.id = @id", sp);
					}
					else
					{
						cmd = CreateCommand("select o.id, o.OrderDate, p.DeliveryOptionId, p.Location, p.PreferredTimeSlot, os.id as OrderStatusId, os.StatusName " +
							"from orderTbl as o inner join deliveryOptionTbl as d on o.DeliveryOptionId = d.id " +
							"inner join pickupDeliveryTbl as p on d.id = p.DeliveryOptionId " +
							"inner join orderStatusTbl as os on os.id = o.OrderStatusId " +
							"where o.id = @id", sp);
					}
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							OrderStatusDTO orderStatus = new OrderStatusDTO
							{
								Id = Convert.ToInt32(dr["OrderStatusId"]),
								Name = Convert.ToString(dr["StatusName"])
							};
							DeliveryOptionDTO deliveryOption;
							if (isHomeDelivery)
							{
								deliveryOption = new HomeDeliveryDTO
								{
									Id = Convert.ToInt32(dr["DeliveryOptionId"]),
									DeliverDateTime = Convert.ToDateTime(dr["DeliverDateTime"])
								};
							}
							else
							{
								deliveryOption = new PickupDeliveryDTO
								{
									Id = Convert.ToInt32(dr["DeliveryOptionId"]),
									Location = Convert.ToString(dr["Location"]),
									PreferredTimeSlot = Convert.ToDateTime(dr["PreferredTimeSlot"])
								};
							}
							found = new OrderDTO();
							found.Id = Convert.ToInt32(dr["id"]);
							found.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
							found.OrderStatus = orderStatus;
							found.DeliveryOption = deliveryOption;
							return found;
						}
						else { throw new Exception("Order with id " + id + " could not be found."); }
					}
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public List<OrderStatusDTO> GetAllOrderStatuses()
		{
			try
			{
				List<OrderStatusDTO> orderStatuses = new List<OrderStatusDTO>();
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [id], [StatusName] from orderStatusTbl");
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while(dr.Read())
						{
							OrderStatusDTO orderStatus = new OrderStatusDTO();
							orderStatus.Id = Convert.ToInt32(dr["id"]);
							orderStatus.Name = Convert.ToString(dr["StatusName"]);
							orderStatuses.Add(orderStatus);
						}
					}
					return orderStatuses;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public int GetCountHomeDelivery(DateTime dateTime)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@datetime", dateTime) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select count(*) from orderTbl as o " +
						"inner join deliveryOptionTbl as d on o.DeliveryOptionId = d.id " +
						"inner join homeDeliveryTbl as h on h.DeliveryOptionId = d.id " +
						"where h.DeliverDateTime = @datetime", sp);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public Dictionary<int, int> GetItemsFromOrder(int orderid)
		{
			try
			{
				Dictionary<int, int> orderitems = new Dictionary<int, int>();
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@orderid", orderid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select [OrderId], [ItemId], [ItemQuantity] from orderLineTbl " +
						"where OrderId = @orderid", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							int itemid = Convert.ToInt32(dr["ItemId"]);
							int itemquantity = Convert.ToInt32(dr["ItemQuantity"]);
							orderitems.Add(itemid, itemquantity);
						}
					}
					return orderitems;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public List<OrderDTO> GetAllPickupDeliveryOrdersFromCustomer(int customerid)
		{
			try
			{
				List<OrderDTO> orders = new List<OrderDTO>();
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@customerid", customerid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select o.id, o.OrderDate, p.DeliveryOptionId, p.Location, p.PreferredTimeSlot, os.id as OrderStatusId, os.StatusName " +
							"from orderTbl as o inner join deliveryOptionTbl as d on o.DeliveryOptionId = d.id " +
							"inner join pickupDeliveryTbl as p on d.id = p.DeliveryOptionId " +
							"inner join orderStatusTbl as os on os.id = o.OrderStatusId " +
							"where o.CustomerId = @customerid", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								OrderStatusDTO orderStatus = new OrderStatusDTO
								{
									Id = Convert.ToInt32(dr["OrderStatusId"]),
									Name = Convert.ToString(dr["StatusName"])
								};
								DeliveryOptionDTO deliveryOption = new PickupDeliveryDTO
								{
									Id = Convert.ToInt32(dr["DeliveryOptionId"]),
									Location = Convert.ToString(dr["Location"]),
									PreferredTimeSlot = Convert.ToDateTime(dr["PreferredTimeSlot"])
								};
								OrderDTO found = new OrderDTO();
									found.Id = Convert.ToInt32(dr["id"]);
									found.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
									found.OrderStatus = orderStatus;
									found.DeliveryOption = deliveryOption;
									orders.Add(found);
							}
						}
						return orders;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		public List<OrderDTO> GetAllHomeDeliveryOrdersFromCustomer(int customerid)
		{
			try
			{
				List<OrderDTO> orders = new List<OrderDTO>();
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@customerid", customerid) };
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("select o.id, o.OrderDate, h.DeliveryOptionId, h.DeliverDateTime, os.id as OrderStatusId, os.StatusName " +
							"from orderTbl as o inner join deliveryOptionTbl as d on o.DeliveryOptionId = d.id " +
							"inner join homeDeliveryTbl as h on d.id = h.DeliveryOptionId " +
							"inner join orderStatusTbl as os on os.id = o.OrderStatusId " +
							"where o.CustomerId = @customerid", sp);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							OrderStatusDTO orderStatus = new OrderStatusDTO
							{
								Id = Convert.ToInt32(dr["OrderStatusId"]),
								Name = Convert.ToString(dr["StatusName"])
							};
							DeliveryOptionDTO deliveryOption = new HomeDeliveryDTO
							{
								Id = Convert.ToInt32(dr["DeliveryOptionId"]),
								DeliverDateTime = Convert.ToDateTime(dr["DeliverDateTime"])
							};
							OrderDTO found = new OrderDTO();
							found.Id = Convert.ToInt32(dr["id"]);
							found.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
							found.OrderStatus = orderStatus;
							found.DeliveryOption = deliveryOption;
							orders.Add(found);
						}
					}
					return orders;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
		//update
		public bool UpdateOrderStatus(int orderid, int orderstatusid)
		{
			try
			{
				SqlParameter[] sp = new SqlParameter[] {
					new SqlParameter("@orderid", orderid),
					new SqlParameter("@orderstatusid", orderstatusid)};
				if (OpenConnection())
				{
					SqlCommand cmd = CreateCommand("update orderTbl set OrderStatusId = @orderstatusid where " +
						"id = @orderid", sp);
					cmd.ExecuteNonQuery();
					return true;
				}
				else { throw new Exception("Database connection could not be opened."); }
			}
			catch (Exception ex) { throw; }
			finally { CloseConnection(); }
		}
	}
}
