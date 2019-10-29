﻿// <auto-generated />
using MedievalPlantGuild.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedievalPlantGuild.Migrations
{
    [DbContext(typeof(MedievalPlantGuildContext))]
    [Migration("20191028231126_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MedievalPlantGuild.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommonName");

                    b.Property<string>("Habitat");

                    b.Property<string>("Identification");

                    b.Property<string>("LatinName");

                    b.Property<bool>("Poisonous");

                    b.Property<string>("Uses");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            CommonName = "American Ginseng",
                            Habitat = "American Ginseng can be found in much of the eastern and central United States and in part of southeastern Canada. It is found primarily in deciduous forests of the Appalachian and Ozark regions of the United States. American ginseng is found in full shade environments in these deciduous forests underneath hardwoods. Due to this very specialized growing environment and its demand in the commercial market it has started to reach an endangered status in some areas. It can be found throughout eastern Canada and the northeastern United States.",
                            Identification = "The aromatic root of American ginseng (Panax quinquefolius) resembles a small parsnip that forks as it matures. The plant grows 6 inches to 18 inches tall, usually bearing three leaves, each with three to five leaflets, 2 inches to 5 inches long.",
                            LatinName = "Panax quinquefolius",
                            Poisonous = true,
                            Uses = "There is no evidence that American ginseng is effective against the common cold or how severe the infections are. There is tentative evidence that it may lessen the length of sickness when used preventively. Individuals requiring anticoagulant therapy such as warfarin should avoid use of ginseng. It is not recommended for individuals with impaired liver or renal function, or during pregnancy or breastfeeding. Other adverse effects include: headaches, anxiety, trouble sleeping and an upset stomach. Recent studies have shown that through the many cultivated procedures that American ginseng is grown, fungal molds, pesticides, and various metals and residues have contaminated the crop. Though these contaminating effects are not considerably substantial, they do pose health concerns that could lead to neurological problems, intoxication, cardiovascular disease and cancer."
                        },
                        new
                        {
                            PlantId = 2,
                            CommonName = "Ginger",
                            Habitat = "From India, it was also carried by traders into the Middle East and the Mediterranean by around the 1st century CE. It was primarily grown in southern India and the Greater Sunda Islands during the spice trade, along with peppers, cloves, and numerous other spices.",
                            Identification = " It is a herbaceous perennial which grows annual pseudostems (false stems made of the rolled bases of leaves) about a meter tall bearing narrow leaf blades. The inflorescences bear pale yellow with purple flowers and arise directly from the rhizome on separate shoots",
                            LatinName = "(Zingiber officinale",
                            Poisonous = false,
                            Uses = "Evidence that ginger helps alleviate nausea and vomiting resulting from chemotherapy or pregnancy is inconsistent.[2][28][29][30] There is no clear evidence of harm from taking ginger during pregnancy, although its safety has not been established.[28][31] Ginger is not effective for treating dysmenorrhea,[32] and there is insufficient evidence for it having analgesic properties due to the lack of well conducted trials. Available data provides weak evidence for its anti-inflammatory role and it may reduce the subjective experience of pain in osteoarthritis. Ginger is also used for various types of spices and teas"
                        },
                        new
                        {
                            PlantId = 3,
                            CommonName = "Turmeric",
                            Habitat = "Native to the Indian subcontinent and Southeast Asia.",
                            Identification = "Turmeric is a perennial herbaceous plant that reaches up to 1 m (3 ft 3 in) tall. Highly branched, yellow to orange, cylindrical, aromatic rhizomes are found.",
                            LatinName = "Curcuma longa",
                            Poisonous = false,
                            Uses = "Culinary, Dye, Indicator, Reduces Inflammation in the body, premote good digestion, premotes more energy. "
                        },
                        new
                        {
                            PlantId = 4,
                            CommonName = "Burdock",
                            Habitat = "Native to Europe and Asia, several species have been widely introduced worldwide. Arctium species generally flower from July through to October. Burdock flowers provide essential pollen and nectar for honeybees around August when clover is on the wane and before the goldenrod starts to bloom.",
                            Identification = "Arctium species generally flower from July through to October. Burdock flowers provide essential pollen and nectar for honeybees around August when clover is on the wane and before the goldenrod starts to bloom.Plants of the genus Arctium have dark green leaves that can grow up to 70 cm (28 in) long. They are generally large, coarse and ovate, with the lower ones being heart-shaped. They are woolly underneath. The leafstalks are generally hollow. The prickly heads of these plants (burrs) are noted for easily catching on to fur and clothing. In England, some birdwatchers have reported that birds have become entangled in the burrs leading to a slow death, as they are unable to free themselves. Burdock's clinging properties, in addition to thus providing an excellent mechanism for seed dispersal, led to the invention of the hook and loop fastener.",
                            LatinName = "Arctium",
                            Poisonous = true,
                            Uses = "Folk herbalists considered dried burdock to be a diuretic, diaphoretic, and a blood purifying agent. The seeds of A. lappa are used in traditional Chinese medicine under the name niubangzi (Chinese: 牛蒡子; pinyin: niúbángzi; some dictionaries list the Chinese as just Chinese: 牛蒡; pinyin: niúbàng). Burdock is a traditional medicinal herb used for many ailments. Burdock root oil extract, also called bur oil, is used in Europe as a scalp treatment. The green, above-ground portions may cause contact dermatitis in individual with allergies as the plant contains lactones."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
