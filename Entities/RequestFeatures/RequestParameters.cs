﻿namespace Entities.RequestFeatures
{
    public abstract class RequestParameters
    {
        private const int maxPageSize = 50;
        private int _pageSize = 10;
        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > maxPageSize ? maxPageSize : value;
        }

        public string OrderBy { get; set; }

        public string Fields { get; set; }
    }
}