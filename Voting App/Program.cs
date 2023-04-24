using System;
using System.Collections.Generic;
using System.Linq;

namespace Voting_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category("Film Kategorileri"));
            categories.Add(new Category("Tech Stack Kategorileri"));
            categories.Add(new Category("Spor Kategorileri"));
            Console.Write("Kullanıcı adınız: ");
            string username = Console.ReadLine();
            User user = User.GetUserByUsername(username);
            if (user == null)
            {
                user = new User(username);
                User.Users.Add(user);
                Console.WriteLine("Yeni kullanıcı kaydedildi.");
            }
            Console.WriteLine("Aşağıdaki kategorilerden birini seçin:");

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i].Name}");
            }
            Console.Write("Seçiminiz (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            categories[choice - 1].Votes++;
            Console.WriteLine($"Teşekkürler, {username}. Oyunuz kaydedildi.");
            int totalVotes = 0;
            foreach (Category category in categories)
            {
                totalVotes += category.Votes;
            }
            Console.WriteLine("KATEGORI\t\t\t\t OY SAYISI\t\t OY ORANI");
            foreach (Category category in categories)
            {
                double votePercentage = (double)category.Votes / totalVotes * 100;
                Console.WriteLine($"{category.Name,-40} {category.Votes,-20} {votePercentage,5:N2}%");
            }
            Console.WriteLine("Program sonlandı. Çıkmak için ENTER tuşuna basın.");
            Console.ReadLine();
        }
    }
}
