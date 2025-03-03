// See https://aka.ms/new-console-template for more information
using System.Drawing;

namespace HttpDemo {
    class BusBoard {
        public static async Task Main() {
            var additionalInformationCategories = await TflClient.GetStopPointAdditionalInformation();
            foreach (var categoryInformation in additionalInformationCategories) {
                Console.WriteLine($"Category: {categoryInformation.category}");
                Console.WriteLine($"Available keys: {string.Join(", ", categoryInformation.availableKeys)}");
            }
        }
    }
}