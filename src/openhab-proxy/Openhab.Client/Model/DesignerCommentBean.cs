/* 
 * openHAB REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Openhab.Client.Model
{
    /// <summary>
    /// DesignerCommentBean
    /// </summary>
    [DataContract]
    public partial class DesignerCommentBean :  IEquatable<DesignerCommentBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignerCommentBean" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="pinned">pinned (default to false).</param>
        /// <param name="w">w.</param>
        /// <param name="h">h.</param>
        public DesignerCommentBean(string text = default(string), bool? pinned = false, int? w = default(int?), int? h = default(int?))
        {
            Text = text;
            // use default value if no "pinned" provided
            if (pinned == null)
            {
                Pinned = false;
            }
            else
            {
                Pinned = pinned;
            }
            W = w;
            H = h;
        }
        
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Gets or Sets W
        /// </summary>
        [DataMember(Name="w", EmitDefaultValue=false)]
        public int? W { get; set; }

        /// <summary>
        /// Gets or Sets H
        /// </summary>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public int? H { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignerCommentBean {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as DesignerCommentBean);
        }

        /// <summary>
        /// Returns true if DesignerCommentBean instances are equal
        /// </summary>
        /// <param name="input">Instance of DesignerCommentBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignerCommentBean input)
        {
            if (input == null)
                return false;

            return 
                (
                    Text == input.Text ||
                    (Text != null &&
                    Text.Equals(input.Text))
                ) && 
                (
                    Pinned == input.Pinned ||
                    (Pinned != null &&
                    Pinned.Equals(input.Pinned))
                ) && 
                (
                    W == input.W ||
                    (W != null &&
                    W.Equals(input.W))
                ) && 
                (
                    H == input.H ||
                    (H != null &&
                    H.Equals(input.H))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                if (Pinned != null)
                    hashCode = hashCode * 59 + Pinned.GetHashCode();
                if (W != null)
                    hashCode = hashCode * 59 + W.GetHashCode();
                if (H != null)
                    hashCode = hashCode * 59 + H.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
