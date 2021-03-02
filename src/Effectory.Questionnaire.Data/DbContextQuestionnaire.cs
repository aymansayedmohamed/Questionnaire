using Effectory.Questionnaire.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Effectory.Questionnaire.Data
{
    public class DbContextQuestionnaire : DbContext
    {
        public DbContextQuestionnaire()
        {
        }

        public DbContextQuestionnaire(DbContextOptions<DbContextQuestionnaire> options) : base(options)
        {

        }
        public DbSet<SubjectText> SubjectTexts { get; set; }
        public DbSet<AnswerText> AnswerTexts { get; set; }
        public DbSet<QuestionText> QuestionTexts { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Entities.Questionnaire> Questionnaires { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionnaireItem> QuestionnaireItems { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Entities.Questionnaire>()
            .HasMany(c => c.QuestionnaireItems)
            .WithOne(e => e.Questionnaire)
            .HasForeignKey(e => e.QuestionnaireId);

            modelBuilder.Entity<QuestionnaireItem>()
            .HasOne(c => c.Subject)
            .WithOne(e => e.QuestionnaireItem);

            modelBuilder.Entity<Subject>()
            .HasMany(c => c.Questions)
            .WithOne(e => e.Subject)
            .HasForeignKey(e => e.SubjectId);

            modelBuilder.Entity<Question>()
            .HasMany(c => c.Answers)
            .WithOne(e => e.Question)
            .HasForeignKey(e => e.QuestionId);

            modelBuilder.Entity<Subject>()
            .HasMany(c => c.Texts)
            .WithOne(e => e.Subject)
            .HasForeignKey(e => e.SubjectId);

            modelBuilder.Entity<Question>()
            .HasMany(c => c.Texts)
            .WithOne(e => e.Question)
            .HasForeignKey(e => e.QuestionId);

            modelBuilder.Entity<Answer>()
            .HasMany(c => c.Texts)
            .WithOne(e => e.Answer)
            .HasForeignKey(e => e.AnswerId);

        }

    }
}
