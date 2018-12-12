using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using People.Models;

namespace People.Services
{
    public class MockDataService : IDataService
    {
        public ObservableCollection<Contact> Contacts { get; set; }     //Tao list danh ba...

        //Tao du lieu gia!
        public Task<ObservableCollection<Contact>> GetContacts()
        {
            var temp = new ObservableCollection<Contact>()
            {
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Jonh",
                    LastName = "Catter",
                    Company = "kajsdhaosd",
                    JobTitle = "askdjasl",
                    Email = "jkabdasasdg@gmail.com",
                    Phone = "0984561456",
                    City = "aojfoiahf",
                    Street = "akjfapsjf",
                    State = "daskjfioa",
                    PhotoUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2F1.bp.blogspot.com%2F-sxT1v_jBAGE%2FWgmvGQ4uTVI%2FAAAAAAAACC4%2FbLZoRL6GeuA9AC9m9xFUzaMjC8tNb_NcwCEwYBhgL%2Fs1600%2F1979c374820a55b38d3cb68bd85da4c0.jpg&imgrefurl=http%3A%2F%2Favatardepvachat.blogspot.com%2F2017%2F11%2Favatar-doi-han-quoc.html&docid=xVrQ3E5kPVZntM&tbnid=gUOcV8_3EnvBmM%3A&vet=10ahUKEwiB_J2VqY3fAhUJa94KHYlkBe4QMwhEKAkwCQ..i&w=564&h=575&bih=969&biw=1920&q=avatar%20ng%C6%B0%E1%BB%9Di%20th%E1%BA%ADt&ved=0ahUKEwiB_J2VqY3fAhUJa94KHYlkBe4QMwhEKAkwCQ&iact=mrc&uact=8",
                },

                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "ahsgas",
                    LastName = "asdahf",
                    Company = "dakknfoaishf",
                    JobTitle = "dalksdalksj",
                    Email = "akfnalsk@gmail.com",
                    Phone = "65489451",
                    City = "asjkdgauyfg",
                    Street = "adijiasoij",
                    State = "daskfojas",
                    PhotoUrl = "https://www.google.com/imgres?imgurl=http%3A%2F%2Fmedia.van.vn%2FThumbnail%2FXXL%2FContentUpload%2F%2Fphuongnt2%2Fhinh_anh_avatar_buon_danh_cho_con_gai_10-240.jpg&imgrefurl=http%3A%2F%2Fwww.van.vn%2Ftu-van%2Ftop-hinh-anh-avatar-buon-co-don-tam-trang-cho-facebook.html&docid=HlNlJxSm3S6z_M&tbnid=xSmR8ndBsbeTLM%3A&vet=10ahUKEwiB_J2VqY3fAhUJa94KHYlkBe4QMwhjKBswGw..i&w=240&h=320&bih=969&biw=1920&q=avatar%20ng%C6%B0%E1%BB%9Di%20th%E1%BA%ADt&ved=0ahUKEwiB_J2VqY3fAhUJa94KHYlkBe4QMwhjKBswGw&iact=mrc&uact=8",
                },

                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "asldkhai",
                    LastName = "asasdjapof",
                    Company = "asfjaofi",
                    JobTitle = "alkfpajsf",
                    Email = "aslfjaiohf",
                    Phone = "54843521",
                    City = "asfjafa",
                    Street = "asashgduayf",
                    State = "asdhgasfb",
                    PhotoUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsv.1phut.mobi%2Fuploads%2F2016%2F04%2Favatar-doi.jpg&imgrefurl=https%3A%2F%2F1phut.mobi%2Fthu-thuat%2Fdi-dong%2Ftong-hop-avatar-doi-facebook-nam-nu-yeu-nhau-cuc-dep.html&docid=AxgTtzwpVpd7EM&tbnid=D_-PsCpA7ypEJM%3A&vet=12ahUKEwiWysOyqY3fAhXPaN4KHQvcBlM4ZBAzKBowGnoECAEQGw..i&w=520&h=480&bih=969&biw=1920&q=avatar%20ng%C6%B0%E1%BB%9Di%20th%E1%BA%ADt&ved=2ahUKEwiWysOyqY3fAhXPaN4KHQvcBlM4ZBAzKBowGnoECAEQGw&iact=mrc&uact=8",
                },

                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "ashgaf",
                    LastName = "alshf",
                    Company = "akjsfhasf",
                    JobTitle = "aushd",
                    Email = "auysgdahsfvyuavf@gmail.com",
                    Phone = "87465489",
                    City = "dahsvyua",
                    Street = "ashvdasfh",
                    State = "asgfasf",
                    PhotoUrl = "https://www.google.com/imgres?imgurl=http%3A%2F%2Fthuthuatphanmem.vn%2Fuploads%2F2018%2F04%2F10%2Favatar-doi-dep-21_015655762.jpg&imgrefurl=http%3A%2F%2Fthuthuatphanmem.vn%2Ftong-hop-avatar-facebook-dep-nhat-hinh-dai-dien-facebook-dep%2F&docid=E86eMba8he2_rM&tbnid=-70IghnkOIrTUM%3A&vet=12ahUKEwiXrOGTqo3fAhWYdd4KHdSVBp842AQQMyhcMFx6BAgBEF8..i&w=360&h=640&bih=969&biw=1920&q=avatar%20ng%C6%B0%E1%BB%9Di%20th%E1%BA%ADt&ved=2ahUKEwiXrOGTqo3fAhWYdd4KHdSVBp842AQQMyhcMFx6BAgBEF8&iact=mrc&uact=8",
                }
            };
            Contacts = new ObservableCollection<Contact>(temp);
            return Task.FromResult(Contacts);
        }

        //Add nguoi dung moi vao Contacts
        public Task AddNewContact(Contact contact)  
        {
            contact.Id = Guid.NewGuid().ToString(); //Ham tao ID nguoi dung ngau nhien
            contact.PhotoUrl = "https://www.yourfirstpatient.com/assets/default-user-avatar-thumbnail@2x-ad6390912469759cda3106088905fa5bfbadc41532fbaa28237209b1aa976fc9.png";
            Contacts.Add(contact);
            return Task.CompletedTask;
        }
    }
}
