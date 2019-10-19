using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Subsctribo.Models;
namespace Subsctribo.ViewModels
{
    public class RandomSubscriptionViewModel
    {
        public Subscription Subscription { get; set; }
        public List<Members> Members { get; set; }
    }
}