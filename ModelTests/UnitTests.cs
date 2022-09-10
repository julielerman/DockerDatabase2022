using System;
using AgilistaTracker;
using Xunit;

namespace ModelTests {
    public class UnitTests {
     
        [Fact]
        public void NewCategoryHasGuid () {
            var category = new Category ("cat");
            Assert.NotEqual (Guid.Empty,category.Id);
        }

        [Fact]
        public void NewCategoryCtorStoresName () {
            var category = new Category ("cat");
            Assert.Equal ("cat", category.Description);
        }

        [Fact]
        public void NewAgilistaHasGuid () {
            var category = new Category ("cat");
            var agilista = new Agilista ("a", category);
            Assert.NotEqual (Guid.Empty,agilista.Id);
        }

        [Fact]
        public void NewAgilistaStoresCategory () {

            var category = new Category ("cat");
            var agilista = new Agilista ("a", category);
            Assert.Equal ("cat",agilista.PrimaryFocus.Description);
        }

        [Fact]
        public void NewAgilistaStoresTwitter () {
            
            var category = new Category ("cat");
            var agilista = new Agilista ("a", category, "@t");
            Assert.Equal ( "@t",agilista.TwitterHandle);
        }
    }
}