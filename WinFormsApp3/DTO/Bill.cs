using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogInDemo.DTO
{
    public class Bill
    {
        private string id;
        private string sid;
        private string username;
        private string term;
        private string fid;
        private int total;
        public string Id { get { return id; } set { id = value; } }
        public string Sid { get { return sid; } set { sid = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Term { get { return term; } set { term = value; } }
        public string Fid { get { return fid; } set { fid = value; } }
        public int Total { get { return total; } set { total = value; } }
        public Bill(string id, string sid, string username, string term, string fid, int total)
        {
            Id = id;
            Sid = sid;
            Username = username;
            Term = term;
            Fid = fid;
            Total = total;
        }
        public Bill(DataRow row)
        {
            Id = row["BID"].ToString();
            Sid = row["SID"].ToString();
            Username = row["USERNAME"].ToString();
            Term = row["TERM"].ToString();
            Fid = row["FID"].ToString();
            Total = (int)row["TOTAL"];
        }
    }
}
