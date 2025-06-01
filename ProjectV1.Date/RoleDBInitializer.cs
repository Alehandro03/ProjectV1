using ProjectV1.Date.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date
{
    public class RoleDBInitializer : DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void AddAllRole(ProjectContext context)
        {
            IList<Role> role = new List<Role>();

            role.Add(new Role() { Name = "Admin" });
            role.Add(new Role() { Name = "User" });
            role.Add(new Role() { Name = "Moderator" });
            role.Add(new Role() { Name = "Developer" });

            //context.Role.AddRAnge(role);
            //base.AddAllRole(context);
        }
    }
}
