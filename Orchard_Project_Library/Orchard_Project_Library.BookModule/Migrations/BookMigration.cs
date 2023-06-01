using Orchard_Project_Library.BookModule.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard_Project_Library.BookModule.Migrations
{
    public class BookMigration : DataMigration
    {
        private readonly IContentDefinitionManager contentDefinitionManager;
        public BookMigration(IContentDefinitionManager contentDefinitionManager)
        {
            this.contentDefinitionManager = contentDefinitionManager;
        }

        public int Create() 
        {
            contentDefinitionManager.AlterPartDefinition(nameof(BookPart), part => part
                .Attachable()

            );

            contentDefinitionManager.AlterTypeDefinition("BookPage", type => type
                .Creatable()
                .Listable()
                .WithPart(nameof(BookPart))
                );

            return 1;
        }
    }
}
