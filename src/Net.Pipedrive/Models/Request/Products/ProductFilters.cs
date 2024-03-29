﻿using System.Collections.Generic;

namespace Net.Pipedrive
{
    public class ProductFilters
    {
        public static ProductFilters None => new ProductFilters();

        public int? StartPage { get; set; }

        public int? PageCount { get; set; }

        public int? PageSize { get; set; }

        public long? UserId { get; set; }

        public long? FilterId { get; set; }

        public string FirstChar { get; set; }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var d = new Dictionary<string, string>();
                if (UserId.HasValue)
                {
                    d.Add("user_id", UserId.Value.ToString());
                }

                if (FilterId.HasValue)
                {
                    d.Add("filter_id", FilterId.Value.ToString());
                }

                if (!string.IsNullOrWhiteSpace(FirstChar))
                {
                    d.Add("first_char", FirstChar);
                }

                return d;
            }
        }
    }
}
