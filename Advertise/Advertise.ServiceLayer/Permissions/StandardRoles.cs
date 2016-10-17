using System;
using System.Collections.Generic;

namespace Advertise.ServiceLayer.Security
{
    /// <summary>
    /// </summary>
    public static class StandardRoles
    {
        #region GetSysmteRoles

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<string> GetSysmteRoles()
        {
            return new List<string>
            {
                Administrators,
                Operators
            };
        }

        #endregion

        #region GetDefaultRolesWithPermissions

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<PermissionRecord> GetDefaultRolesWithPermissions()
        {
            return new List<PermissionRecord>
            {
                new PermissionRecord
                {
                    RoleName = Administrators,
                    Permissions = AssignableToRolePermissions.Permissions
                },
                new PermissionRecord
                {
                    RoleName = Operators,
                    Permissions = new List<PermissionModel>
                    {
                        AssignableToRolePermissions.CanManageAddressPermission,
                        AssignableToRolePermissions.CanManageAppraiserPermission,
                        AssignableToRolePermissions.CanManageEducationalBackgroundPermission,
                        AssignableToRolePermissions.CanManageFavoriteIssuePermission,
                        AssignableToRolePermissions.CanManageInstitutionPermission,
                        AssignableToRolePermissions.CanManageInterviewPermission,
                        AssignableToRolePermissions.CanManageApplicantInServiceCourseTypePermission,
                        AssignableToRolePermissions.CanManageArticlePermission,
                        AssignableToRolePermissions.CanManageOrganizationalTeachingPermission,
                        AssignableToRolePermissions.CanManageResearchExperiencePermission,
                        AssignableToRolePermissions.CanManageScientificTeachingPermission,
                        AssignableToRolePermissions.CanManageTrainingCenterPermission,
                        AssignableToRolePermissions.CanManageTrainingCoursePermission,
                        AssignableToRolePermissions.CanManageWorkExperiencePermission,
                        AssignableToRolePermissions.CanManageAdoptedPriorityPermission,
                        AssignableToRolePermissions.CanManageEntireEvaluationPermission,
                        AssignableToRolePermissions.CanViewApplicantDetailsPermission,
                        AssignableToRolePermissions.CanManageArticleEvaluationPermission,
                        AssignableToRolePermissions.CanUsePrivateMessagePermission,
                        AssignableToRolePermissions.CanEditApplicantPermission,
                        AssignableToRolePermissions.CanCreateApplicantPermission
                    }
                }
            };
        }

        #endregion

        #region Fields

        private static Lazy<IEnumerable<PermissionRecord>> _rolesWithPermissionsLazy =
            new Lazy<IEnumerable<PermissionRecord>>();

        private static Lazy<IEnumerable<string>> _rolesLazy = new Lazy<IEnumerable<string>>();

        #endregion

        #region Properties

        /// <summary>
        /// </summary>
        public static IEnumerable<string> SystemRoles
        {
            get
            {
                if (_rolesLazy.IsValueCreated)
                    return _rolesLazy.Value;
                _rolesLazy = new Lazy<IEnumerable<string>>(GetSysmteRoles);
                return _rolesLazy.Value;
            }
        }

        /// <summary>
        /// </summary>
        public static IEnumerable<PermissionRecord> SystemRolesWithPermissions
        {
            get
            {
                if (_rolesWithPermissionsLazy.IsValueCreated)
                    return _rolesWithPermissionsLazy.Value;
                _rolesWithPermissionsLazy = new Lazy<IEnumerable<PermissionRecord>>(GetDefaultRolesWithPermissions);
                return _rolesWithPermissionsLazy.Value;
            }
        }

        #endregion

        #region DefaultRoles

        public const string Administrators = "مدیران";
        public const string Operators = "اپراتور ها";

        #endregion
    }
}