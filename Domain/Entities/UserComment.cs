using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class UserComment
    {

        public string? Text        { set; get; }
        public double Rate        { set; get; }


        public CommentStatus CommentStatus { set; get; }
        public virtual Client? User  { set; get; }

    }
}
