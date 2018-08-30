﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dnd_project.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dnd_project.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;attributes&quot;:{
        ///      &quot;Strength&quot;:{
        ///         &quot;Description&quot;:&quot;Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force. It can model any attempt to lift, push, pull, or break something, to force your body through a space, or to otherwise apply brute force to a situation.&quot;
        ///      },
        ///      &quot;Dexterity&quot;:{
        ///         &quot;Description&quot;:&quot;Dexterity measures agility, reflexes, and balance. It can model any attempt to move nimbly, quickly, or quietly, or to keep from [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttributeData {
            get {
                return ResourceManager.GetString("AttributeData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;classes&quot;:{
        ///      &quot;Barbarian&quot;:{
        ///         &quot;Description&quot;:&quot;A fierce warrior of primitive background who can enter a battle rage.&quot;,
        ///         &quot;HitDie&quot;:&quot;d12&quot;,
        ///         &quot;PrimaryAttributes&quot;:[
        ///            &quot;Strength&quot;
        ///         ],
        ///         &quot;SavingThrows&quot;:[
        ///            &quot;Strength&quot;,
        ///            &quot;Constitution&quot;
        ///         ],
        ///         &quot;Proficiencies&quot;:[
        ///            &quot;Light Armor&quot;,
        ///            &quot;Medium Armor&quot;,
        ///            &quot;Shields&quot;,
        ///            &quot;Simple Weapons&quot;,
        ///            &quot;Martial Weapons&quot;
        ///         ],
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ClassData {
            get {
                return ResourceManager.GetString("ClassData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon d20 {
            get {
                object obj = ResourceManager.GetObject("d20", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;feats&quot;:{
        ///      &quot;Arcane Recovery&quot;:{
        ///         &quot;Description&quot;:&quot;You have learned to regain some of your magical energy by studying your spellbook. Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard level (rounded up), and none o f the slots can be 6th level or higher. For example, if you’re a 4th-level wizard, you can recover up to two levels worth of spell slots. You can reco [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FeatData {
            get {
                return ResourceManager.GetString("FeatData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;races&quot;:{
        ///      &quot;Hill Dwarf&quot;:{
        ///         &quot;Ages&quot;:[
        ///            50,
        ///            350
        ///         ],
        ///         &quot;Size&quot;:&quot;Medium&quot;,
        ///         &quot;CommonAlignment&quot;:&quot;Lawful&quot;,
        ///         &quot;Movement&quot;:25,
        ///         &quot;AttributeScores&quot;:[
        ///            {
        ///               &quot;Attribute&quot;:&quot;Constitution&quot;,
        ///               &quot;Change&quot;:2
        ///            },
        ///            {
        ///               &quot;Attribute&quot;:&quot;Wisdom&quot;,
        ///               &quot;Change&quot;:1
        ///            }
        ///         ],
        ///         &quot;Feats&quot;:[
        ///            &quot;Darkvision&quot;,
        ///            &quot;Dwarven Resilienc [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RaceData {
            get {
                return ResourceManager.GetString("RaceData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;skills&quot;:{
        ///      &quot;Athletics&quot;:{
        ///         &quot;ParentAttribute&quot;:&quot;Strength&quot;,
        ///         &quot;Description&quot;:&quot;Covers difficult situations you encounter while climbing, jumping, or swimming.&quot;
        ///      },
        ///      &quot;Acrobatics&quot;:{
        ///         &quot;ParentAttribute&quot;:&quot;Dexterity&quot;,
        ///         &quot;Description&quot;:&quot;Covers your attempt to stay on your feet in a tricky situation, such as when you’re trying to run across a sheet of ice, balance on a tightrope, or stay upright on a rocking ship’s deck.&quot;
        ///      },
        ///      &quot;Sleight of Hand&quot;:{
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SkillsData {
            get {
                return ResourceManager.GetString("SkillsData", resourceCulture);
            }
        }
    }
}
