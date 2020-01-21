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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Openhab.Client.Model
{
    /// <summary>
    /// ChannelDefinitionDTO
    /// </summary>
    [DataContract]
    public partial class ChannelDefinitionDTO :  IEquatable<ChannelDefinitionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDefinitionDTO" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="label">label.</param>
        /// <param name="tags">tags.</param>
        /// <param name="properties">properties.</param>
        /// <param name="category">category.</param>
        /// <param name="stateDescription">stateDescription.</param>
        /// <param name="advanced">advanced (default to false).</param>
        /// <param name="typeUID">typeUID.</param>
        public ChannelDefinitionDTO(string description = default(string), string id = default(string), string label = default(string), List<string> tags = default(List<string>), Dictionary<string, string> properties = default(Dictionary<string, string>), string category = default(string), StateDescription stateDescription = default(StateDescription), bool? advanced = false, string typeUID = default(string))
        {
            Description = description;
            Id = id;
            Label = label;
            Tags = tags;
            Properties = properties;
            Category = category;
            StateDescription = stateDescription;
            // use default value if no "advanced" provided
            if (advanced == null)
            {
                Advanced = false;
            }
            else
            {
                Advanced = advanced;
            }
            TypeUID = typeUID;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets StateDescription
        /// </summary>
        [DataMember(Name="stateDescription", EmitDefaultValue=false)]
        public StateDescription StateDescription { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name="advanced", EmitDefaultValue=false)]
        public bool? Advanced { get; set; }

        /// <summary>
        /// Gets or Sets TypeUID
        /// </summary>
        [DataMember(Name="typeUID", EmitDefaultValue=false)]
        public string TypeUID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelDefinitionDTO {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  StateDescription: ").Append(StateDescription).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  TypeUID: ").Append(TypeUID).Append("\n");
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
            return Equals(input as ChannelDefinitionDTO);
        }

        /// <summary>
        /// Returns true if ChannelDefinitionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelDefinitionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelDefinitionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Label == input.Label ||
                    (Label != null &&
                    Label.Equals(input.Label))
                ) && 
                (
                    Tags == input.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    Properties == input.Properties ||
                    Properties != null &&
                    Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    Category == input.Category ||
                    (Category != null &&
                    Category.Equals(input.Category))
                ) && 
                (
                    StateDescription == input.StateDescription ||
                    (StateDescription != null &&
                    StateDescription.Equals(input.StateDescription))
                ) && 
                (
                    Advanced == input.Advanced ||
                    (Advanced != null &&
                    Advanced.Equals(input.Advanced))
                ) && 
                (
                    TypeUID == input.TypeUID ||
                    (TypeUID != null &&
                    TypeUID.Equals(input.TypeUID))
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                if (Properties != null)
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                if (StateDescription != null)
                    hashCode = hashCode * 59 + StateDescription.GetHashCode();
                if (Advanced != null)
                    hashCode = hashCode * 59 + Advanced.GetHashCode();
                if (TypeUID != null)
                    hashCode = hashCode * 59 + TypeUID.GetHashCode();
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