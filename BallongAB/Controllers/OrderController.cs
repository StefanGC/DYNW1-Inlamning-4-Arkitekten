﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BallongAB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BallongAB.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Din varukorg är tom, lägg till några pajer först");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Tack för din beställning.";
            return View();
        }
    }
}