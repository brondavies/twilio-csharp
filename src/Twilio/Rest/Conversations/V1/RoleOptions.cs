/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using System.Linq;



namespace Twilio.Rest.Conversations.V1
{

    /// <summary> Create a new user role in your account's default service </summary>
    public class CreateRoleOptions : IOptions<RoleResource>
    {
        
        ///<summary> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; }

        
        public RoleResource.RoleTypeEnum Type { get; }

        ///<summary> A permission that you grant to the new role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. The values for this parameter depend on the role's `type`. </summary> 
        public List<string> Permission { get; }


        /// <summary> Construct a new CreateRoleOptions </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>        /// <param name="type">  </param>        /// <param name="permission"> A permission that you grant to the new role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. The values for this parameter depend on the role's `type`. </param>
        public CreateRoleOptions(string friendlyName, RoleResource.RoleTypeEnum type, List<string> permission)
        {
            FriendlyName = friendlyName;
            Type = type;
            Permission = permission;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            if (Permission != null)
            {
                p.AddRange(Permission.Select(Permission => new KeyValuePair<string, string>("Permission", Permission)));
            }
            return p;
        }
        

    }
    /// <summary> Remove a user role from your account's default service </summary>
    public class DeleteRoleOptions : IOptions<RoleResource>
    {
        
        ///<summary> The SID of the Role resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteRoleOptions </summary>
        /// <param name="pathSid"> The SID of the Role resource to delete. </param>
        public DeleteRoleOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a user role from your account's default service </summary>
    public class FetchRoleOptions : IOptions<RoleResource>
    {
    
        ///<summary> The SID of the Role resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchRoleOptions </summary>
        /// <param name="pathSid"> The SID of the Role resource to fetch. </param>
        public FetchRoleOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all user roles in your account's default service </summary>
    public class ReadRoleOptions : ReadOptions<RoleResource>
    {
    



        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update an existing user role in your account's default service </summary>
    public class UpdateRoleOptions : IOptions<RoleResource>
    {
    
        ///<summary> The SID of the Role resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A permission that you grant to the role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. Note that the update action replaces all previously assigned permissions with those defined in the update action. To remove a permission, do not include it in the subsequent update action. The values for this parameter depend on the role's `type`. </summary> 
        public List<string> Permission { get; }



        /// <summary> Construct a new UpdateRoleOptions </summary>
        /// <param name="pathSid"> The SID of the Role resource to update. </param>        /// <param name="permission"> A permission that you grant to the role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. Note that the update action replaces all previously assigned permissions with those defined in the update action. To remove a permission, do not include it in the subsequent update action. The values for this parameter depend on the role's `type`. </param>
        public UpdateRoleOptions(string pathSid, List<string> permission)
        {
            PathSid = pathSid;
            Permission = permission;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Permission != null)
            {
                p.AddRange(Permission.Select(Permission => new KeyValuePair<string, string>("Permission", Permission)));
            }
            return p;
        }
        

    }


}

