// <auto-generated />
namespace SSBPD.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class addUserGuids : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201204072054491_addUserGuids"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}