﻿using System.Collections.Generic;

namespace Net.Pipedrive
{
    public class OrganizationUpdateFilters
    {
        public static OrganizationUpdateFilters None
        {
            get { return new OrganizationUpdateFilters(); }
        }

        public int? StartPage { get; set; }

        public int? PageCount { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Get the query parameters that will be appending onto the search
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get
            {
                var d = new Dictionary<string, string>();
                return d;
            }
        }
    }
}
