﻿using backend.Interface;
using backend.Interface.Customter;
using backend.ModelDTO.Customer.OrderDetailRespond;
using backend.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Services.CustomerServices
{
    public class OrderDetailServices : IOrderDetail
    {
        private readonly DataContext _dataContext;

        public OrderDetailServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public OrderDetailRespond GetOrderDetailRespond(string orderID)
        {
            var getOrderTicket = _dataContext.orderDetail.Where(x => x.orderId.Equals(orderID)).ToList();
            var getOrderFood = _dataContext.orderDetailFood.Where(x => x.orderId.Equals(orderID)).Include(x => x.foodInformation).ToList();

            var orderDetailRespond = new OrderDetailRespond()
            {
                orderId = orderID,
                DetailTickets = getOrderTicket ,
                DetailFoods = getOrderFood
            };

            return orderDetailRespond;
        }
    }
}
