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
    /// ChartItemConfigBean
    /// </summary>
    [DataContract]
    public partial class ChartItemConfigBean :  IEquatable<ChartItemConfigBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartItemConfigBean" /> class.
        /// </summary>
        /// <param name="item">item.</param>
        /// <param name="axis">axis.</param>
        /// <param name="label">label.</param>
        /// <param name="chart">chart.</param>
        /// <param name="legend">legend (default to false).</param>
        /// <param name="fill">fill (default to false).</param>
        /// <param name="lineColor">lineColor.</param>
        /// <param name="lineWidth">lineWidth.</param>
        /// <param name="lineStyle">lineStyle.</param>
        /// <param name="markerColor">markerColor.</param>
        /// <param name="markerSymbol">markerSymbol.</param>
        /// <param name="repeatTime">repeatTime.</param>
        public ChartItemConfigBean(string item = default(string), string axis = default(string), string label = default(string), string chart = default(string), bool? legend = false, bool? fill = false, string lineColor = default(string), string lineWidth = default(string), string lineStyle = default(string), string markerColor = default(string), string markerSymbol = default(string), int? repeatTime = default(int?))
        {
            Item = item;
            Axis = axis;
            Label = label;
            Chart = chart;
            // use default value if no "legend" provided
            if (legend == null)
            {
                Legend = false;
            }
            else
            {
                Legend = legend;
            }
            // use default value if no "fill" provided
            if (fill == null)
            {
                Fill = false;
            }
            else
            {
                Fill = fill;
            }
            LineColor = lineColor;
            LineWidth = lineWidth;
            LineStyle = lineStyle;
            MarkerColor = markerColor;
            MarkerSymbol = markerSymbol;
            RepeatTime = repeatTime;
        }
        
        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public string Item { get; set; }

        /// <summary>
        /// Gets or Sets Axis
        /// </summary>
        [DataMember(Name="axis", EmitDefaultValue=false)]
        public string Axis { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Chart
        /// </summary>
        [DataMember(Name="chart", EmitDefaultValue=false)]
        public string Chart { get; set; }

        /// <summary>
        /// Gets or Sets Legend
        /// </summary>
        [DataMember(Name="legend", EmitDefaultValue=false)]
        public bool? Legend { get; set; }

        /// <summary>
        /// Gets or Sets Fill
        /// </summary>
        [DataMember(Name="fill", EmitDefaultValue=false)]
        public bool? Fill { get; set; }

        /// <summary>
        /// Gets or Sets LineColor
        /// </summary>
        [DataMember(Name="lineColor", EmitDefaultValue=false)]
        public string LineColor { get; set; }

        /// <summary>
        /// Gets or Sets LineWidth
        /// </summary>
        [DataMember(Name="lineWidth", EmitDefaultValue=false)]
        public string LineWidth { get; set; }

        /// <summary>
        /// Gets or Sets LineStyle
        /// </summary>
        [DataMember(Name="lineStyle", EmitDefaultValue=false)]
        public string LineStyle { get; set; }

        /// <summary>
        /// Gets or Sets MarkerColor
        /// </summary>
        [DataMember(Name="markerColor", EmitDefaultValue=false)]
        public string MarkerColor { get; set; }

        /// <summary>
        /// Gets or Sets MarkerSymbol
        /// </summary>
        [DataMember(Name="markerSymbol", EmitDefaultValue=false)]
        public string MarkerSymbol { get; set; }

        /// <summary>
        /// Gets or Sets RepeatTime
        /// </summary>
        [DataMember(Name="repeatTime", EmitDefaultValue=false)]
        public int? RepeatTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartItemConfigBean {\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Axis: ").Append(Axis).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Chart: ").Append(Chart).Append("\n");
            sb.Append("  Legend: ").Append(Legend).Append("\n");
            sb.Append("  Fill: ").Append(Fill).Append("\n");
            sb.Append("  LineColor: ").Append(LineColor).Append("\n");
            sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
            sb.Append("  LineStyle: ").Append(LineStyle).Append("\n");
            sb.Append("  MarkerColor: ").Append(MarkerColor).Append("\n");
            sb.Append("  MarkerSymbol: ").Append(MarkerSymbol).Append("\n");
            sb.Append("  RepeatTime: ").Append(RepeatTime).Append("\n");
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
            return Equals(input as ChartItemConfigBean);
        }

        /// <summary>
        /// Returns true if ChartItemConfigBean instances are equal
        /// </summary>
        /// <param name="input">Instance of ChartItemConfigBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartItemConfigBean input)
        {
            if (input == null)
                return false;

            return 
                (
                    Item == input.Item ||
                    (Item != null &&
                    Item.Equals(input.Item))
                ) && 
                (
                    Axis == input.Axis ||
                    (Axis != null &&
                    Axis.Equals(input.Axis))
                ) && 
                (
                    Label == input.Label ||
                    (Label != null &&
                    Label.Equals(input.Label))
                ) && 
                (
                    Chart == input.Chart ||
                    (Chart != null &&
                    Chart.Equals(input.Chart))
                ) && 
                (
                    Legend == input.Legend ||
                    (Legend != null &&
                    Legend.Equals(input.Legend))
                ) && 
                (
                    Fill == input.Fill ||
                    (Fill != null &&
                    Fill.Equals(input.Fill))
                ) && 
                (
                    LineColor == input.LineColor ||
                    (LineColor != null &&
                    LineColor.Equals(input.LineColor))
                ) && 
                (
                    LineWidth == input.LineWidth ||
                    (LineWidth != null &&
                    LineWidth.Equals(input.LineWidth))
                ) && 
                (
                    LineStyle == input.LineStyle ||
                    (LineStyle != null &&
                    LineStyle.Equals(input.LineStyle))
                ) && 
                (
                    MarkerColor == input.MarkerColor ||
                    (MarkerColor != null &&
                    MarkerColor.Equals(input.MarkerColor))
                ) && 
                (
                    MarkerSymbol == input.MarkerSymbol ||
                    (MarkerSymbol != null &&
                    MarkerSymbol.Equals(input.MarkerSymbol))
                ) && 
                (
                    RepeatTime == input.RepeatTime ||
                    (RepeatTime != null &&
                    RepeatTime.Equals(input.RepeatTime))
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
                if (Item != null)
                    hashCode = hashCode * 59 + Item.GetHashCode();
                if (Axis != null)
                    hashCode = hashCode * 59 + Axis.GetHashCode();
                if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                if (Chart != null)
                    hashCode = hashCode * 59 + Chart.GetHashCode();
                if (Legend != null)
                    hashCode = hashCode * 59 + Legend.GetHashCode();
                if (Fill != null)
                    hashCode = hashCode * 59 + Fill.GetHashCode();
                if (LineColor != null)
                    hashCode = hashCode * 59 + LineColor.GetHashCode();
                if (LineWidth != null)
                    hashCode = hashCode * 59 + LineWidth.GetHashCode();
                if (LineStyle != null)
                    hashCode = hashCode * 59 + LineStyle.GetHashCode();
                if (MarkerColor != null)
                    hashCode = hashCode * 59 + MarkerColor.GetHashCode();
                if (MarkerSymbol != null)
                    hashCode = hashCode * 59 + MarkerSymbol.GetHashCode();
                if (RepeatTime != null)
                    hashCode = hashCode * 59 + RepeatTime.GetHashCode();
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