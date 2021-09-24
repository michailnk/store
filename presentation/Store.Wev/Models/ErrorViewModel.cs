using System;

namespace Store.Wev.Models {
   public class ErrorViewModel {
      public string RequestId { get; set; }

      public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
      }
   }
