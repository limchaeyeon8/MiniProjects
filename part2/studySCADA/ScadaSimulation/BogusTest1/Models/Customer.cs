﻿using System;
using System.Collections.Generic;

namespace BogusTest1.Models
{
    public class Customer                               // 고객 테이블이랑 매핑
    {
        public Guid Id { get; set; }                    // 고객 아이디
        public string Name { get; set; }                // 고객명
        public string Address { get; set; }             // 고객주소
        public string Phone { get; set; }               // 전화번호
        public string ContectName { get; set; }         // 연락처명
        public IEnumerable<Order> Orders { get; set; }  // 주문한 리스트
    }
}
