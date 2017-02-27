using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Redmine.Net.Api.Types;
using Redmine.Net.Api.Extensions;

namespace Redmine.Net.Api.JSonConverters
{
    internal class CustomFieldRoleConverter : IdentifiableNameConverter
    {
        #region Overrides of JavaScriptConverter

        /// <summary>
        ///     Deserializes the specified dictionary.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="type">The type.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns></returns>
        public override object Deserialize(IDictionary<string, object> dictionary, Type type,
            JavaScriptSerializer serializer)
        {
            if (dictionary != null)
            {
                var entity = new CustomFieldRole();

                entity.Id = dictionary.GetValue<int>(RedmineKeys.ID);
                entity.Name = dictionary.GetValue<string>(RedmineKeys.NAME);

                return entity;
            }

            return null;
        }

        /// <summary>
        ///     Serializes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns></returns>
        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            return null;
        }

        /// <summary>
        ///     Gets the supported types.
        /// </summary>
        /// <value>
        ///     The supported types.
        /// </value>
        public override IEnumerable<Type> SupportedTypes
        {
            get { return new List<Type>(new[] {typeof(CustomFieldRole)}); }
        }

        #endregion
    }
}