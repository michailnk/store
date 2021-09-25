using Xunit;

namespace Store.Test {
   public class BookTests {
      [Fact]
      public void IsIsbn_WithNull_ReturnFalse() {
         bool actual = Book.IsIsbn(null);
         Assert.False(actual);
         }


      [Fact]
      public void IsIsbn_WithBlankString_ReturnFalse() {
         bool actual = Book.IsIsbn("  ");
         Assert.False(actual);
         }

      [Fact]
      public void IsIsbn_WithInvalidIsbn_ReturnFalse() {
         bool actual = Book.IsIsbn("ISBN 1234");
         Assert.False(actual);
         }

      [Fact]
      public void IsIsbn_WithIsbn10digit_ReturnTrue() {
         bool actual = Book.IsIsbn("iSBN 123-43200 87 ");
         Assert.True(actual);
         }

      [Fact]
      public void IsIsbn_WithIsbn13digit_ReturnTrue() {
         bool actual = Book.IsIsbn("iSBN 123-43200 87 123  ");
         Assert.True(actual);
         }

      [Fact]
      public void IsIsbn_WithIsbn1TrashStartEnd_ReturnFalse() {
         bool actual = Book.IsIsbn("aa iSBN 123-43200 87 8u");
         Assert.False(actual);
         }
      }
   }