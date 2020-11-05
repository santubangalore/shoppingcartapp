using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Authentication
{
    public static class PermissionChecker
    {
        public static bool ThisPermissionIsAllowed(this string packedPermissions, string permissionName)
        {
            var usersPermissions = packedPermissions.UnpackPermissionsFromString().ToArray();

            if (!Enum.TryParse(permissionName, true, out Permissions permissionToCheck))
                throw new InvalidEnumArgumentException($"{permissionName} could not be converted to a {nameof(Permissions)}.");

            return usersPermissions.Contains(permissionToCheck);
        }

        public static List<string> GetPermissionList(this string packedPermissions)
        {
            var usersPermissions = packedPermissions.UnpackPermissionsFromString().ToArray();

            List<string> PermissionList = new List<string>();

            foreach (var PermissionString in usersPermissions)
            {
                PermissionList.Add(PermissionString.ToString());
            }

            return PermissionList;
        }
    }
}
