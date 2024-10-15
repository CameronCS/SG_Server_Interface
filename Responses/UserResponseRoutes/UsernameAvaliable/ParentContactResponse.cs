using SG_Server_Interface.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Server_Interface.Responses.UserResponseRoutes.UsernameAvaliable {
    public class ParentContactResponse {
        public List<ParentContact> Parents {
            get; set;
        }

        public int Code {
            get; set;
        }

        public ParentContactResponse(List<ParentContact> parents, int code) {
            this.Parents = parents;
            this.Code = code;
        }

        internal ParentContactResponse(ParentContactResponseRaw raw, int code) {
            this.Parents = raw.parents;
            this.Code = code;
        }
    }
}
