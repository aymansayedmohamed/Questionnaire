using Microsoft.EntityFrameworkCore.Migrations;

namespace Effectory.Questionnaire.Migrations
{
    public partial class DataInitiation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"USE [Effectory.Questionnaire]  INSERT INTO [dbo].[Departments] ([Name]) VALUES ('marketing'),('sales'),('development'),('reception') declare @depId int; select @depId = Id from Departments where Name ='development' INSERT INTO [dbo].[Users] ([Name] ,[DepartmentId]) VALUES ('Ayman' ,@depId) INSERT INTO [dbo].[Questionnaires] ([QuestionnaireName]) VALUES ('Effectory Questionnaire') INSERT INTO [dbo].[QuestionnaireItems] ([OrderNumber] ,[QuestionnaireId]) VALUES (0 ,SCOPE_IDENTITY()) INSERT INTO [dbo].[Subjects] ([QuestionnaireItemId]) VALUES (SCOPE_IDENTITY()) INSERT INTO [dbo].[SubjectTexts] ([Value] ,[Code] ,[SubjectId]) VALUES ('Mijn werk' ,'nl-NL' ,SCOPE_IDENTITY()) INSERT INTO [dbo].[Questions] ([SubjectId] ,[OrderNumber]) VALUES (SCOPE_IDENTITY() ,0) declare @questionId int = SCOPE_IDENTITY(); INSERT INTO [dbo].[QuestionTexts] ([Value] ,[Code] ,[QuestionId]) VALUES ('I am happy with my work' ,'en-US' ,@questionId) , ('Ik ben blij met mijn werk' ,'nl-NL' ,@questionId) INSERT INTO [dbo].[Answers] ([QuestionId] ,[OrderNumber] ,[AnswerType]) VALUES (@questionId ,0 ,0) INSERT INTO [dbo].[AnswerTexts] ([Value] ,[Code] ,[AnswerId]) VALUES ('Strongly disagree' ,'en-US' ,SCOPE_IDENTITY()), ('Helemaal mee oneens' ,'nl-NL' ,SCOPE_IDENTITY()) INSERT INTO [dbo].[Answers] ([QuestionId] ,[OrderNumber] ,[AnswerType]) VALUES (@questionId ,1 ,0) INSERT INTO [dbo].[AnswerTexts] ([Value] ,[Code] ,[AnswerId]) VALUES ('Disagree' ,'en-US' ,SCOPE_IDENTITY()), ('Mee oneens' ,'nl-NL' ,SCOPE_IDENTITY()) INSERT INTO [dbo].[Answers] ([QuestionId] ,[OrderNumber] ,[AnswerType]) VALUES (@questionId ,2 ,0) INSERT INTO [dbo].[AnswerTexts] ([Value] ,[Code] ,[AnswerId]) VALUES ('Neither agree nor disagree' ,'en-US' ,SCOPE_IDENTITY()), ('Niet mee eens/ niet mee oneens' ,'nl-NL' ,SCOPE_IDENTITY()) INSERT INTO [dbo].[Answers] ([QuestionId] ,[OrderNumber] ,[AnswerType]) VALUES (@questionId ,3 ,0) INSERT INTO [dbo].[AnswerTexts] ([Value] ,[Code] ,[AnswerId]) VALUES ('Agree' ,'en-US' ,SCOPE_IDENTITY()), ('Mee eens' ,'nl-NL' ,SCOPE_IDENTITY()) INSERT INTO [dbo].[Answers] ([QuestionId] ,[OrderNumber] ,[AnswerType]) VALUES (@questionId ,4 ,0) INSERT INTO [dbo].[AnswerTexts] ([Value] ,[Code] ,[AnswerId]) VALUES ('Strongly agree' ,'en-US' ,SCOPE_IDENTITY()), ('Helemaal mee eens' ,'nl-NL' ,SCOPE_IDENTITY()) ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
