﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Authentication
{
    public static class PermissionPackers
    {
        public const char PackType = 'H';
        public const int PackedSize = 4;

        public static string FormDefaultPackPrefix()
        {
            return $"{PackType}{PackedSize:D1}-";
        }

        public static string PackPermissionsIntoString(this IEnumerable<Permissions> permissions)
        {
            return permissions.Aggregate(FormDefaultPackPrefix(), (s, permission) => s + ((int)permission).ToString("X4"));
        }

        public static IEnumerable<int> UnpackPermissionValuesFromString(this string packedPermissions)
        {
            var packPrefix = FormDefaultPackPrefix();
            if (packedPermissions == null)
                throw new ArgumentNullException(nameof(packedPermissions));
            if (!packedPermissions.StartsWith(packPrefix))
                throw new InvalidOperationException("The format of the packed permissions is wrong" +
                                                    $" - should start with {packPrefix}");

            int index = packPrefix.Length;
            while (index < packedPermissions.Length)
            {
                yield return int.Parse(packedPermissions.Substring(index, PackedSize), NumberStyles.HexNumber);
                index += PackedSize;
            }
        }

        public static IEnumerable<Permissions> UnpackPermissionsFromString(this string packedPermissions)
        {
            return packedPermissions.UnpackPermissionValuesFromString().Select(x => ((Permissions)x));
        }

        public static Permissions? FindPermissionViaName(this string permissionName)
        {
            return Enum.TryParse(permissionName, out Permissions permission)
                ? (Permissions?)permission
                : null;
        }

    }
}
