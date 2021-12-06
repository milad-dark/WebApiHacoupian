using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblJob
    {
        public TblJob()
        {
            TblEmploymentRequests = new HashSet<TblEmploymentRequest>();
            TblEmployments = new HashSet<TblEmployment>();
            TblJobAbilities = new HashSet<TblJobAbility>();
            TblJobCompetencies = new HashSet<TblJobCompetency>();
            TblJobCourses = new HashSet<TblJobCourse>();
            TblJobDescriptions = new HashSet<TblJobDescription>();
            TblJobEducations = new HashSet<TblJobEducation>();
            TblJobEvaluations = new HashSet<TblJobEvaluation>();
            TblJobGoals = new HashSet<TblJobGoal>();
            TblJobInterests = new HashSet<TblJobInterest>();
            TblJobKnowledges = new HashSet<TblJobKnowledge>();
            TblJobModelFactorPrefereds = new HashSet<TblJobModelFactorPrefered>();
            TblJobPsychologies = new HashSet<TblJobPsychology>();
            TblJobResponsibilities = new HashSet<TblJobResponsibility>();
            TblJobSkills = new HashSet<TblJobSkill>();
            TblJobSoftwares = new HashSet<TblJobSoftware>();
            TblJobWorkConditions = new HashSet<TblJobWorkCondition>();
            TblPeople = new HashSet<TblPerson>();
        }

        public long Id { get; set; }
        public long TblPostId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblJobGroupId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long YearOfExperience { get; set; }
        public bool EducationalSubstitution { get; set; }
        public byte Sexuality { get; set; }
        public int FromAge { get; set; }
        public int ToAge { get; set; }
        public bool Internship { get; set; }
        public string Vision { get; set; }
        public string Mbti { get; set; }
        public string RevisionDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblJobGroup TblJobGroup { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual TblPost TblPost { get; set; }
        public virtual ICollection<TblEmploymentRequest> TblEmploymentRequests { get; set; }
        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
        public virtual ICollection<TblJobAbility> TblJobAbilities { get; set; }
        public virtual ICollection<TblJobCompetency> TblJobCompetencies { get; set; }
        public virtual ICollection<TblJobCourse> TblJobCourses { get; set; }
        public virtual ICollection<TblJobDescription> TblJobDescriptions { get; set; }
        public virtual ICollection<TblJobEducation> TblJobEducations { get; set; }
        public virtual ICollection<TblJobEvaluation> TblJobEvaluations { get; set; }
        public virtual ICollection<TblJobGoal> TblJobGoals { get; set; }
        public virtual ICollection<TblJobInterest> TblJobInterests { get; set; }
        public virtual ICollection<TblJobKnowledge> TblJobKnowledges { get; set; }
        public virtual ICollection<TblJobModelFactorPrefered> TblJobModelFactorPrefereds { get; set; }
        public virtual ICollection<TblJobPsychology> TblJobPsychologies { get; set; }
        public virtual ICollection<TblJobResponsibility> TblJobResponsibilities { get; set; }
        public virtual ICollection<TblJobSkill> TblJobSkills { get; set; }
        public virtual ICollection<TblJobSoftware> TblJobSoftwares { get; set; }
        public virtual ICollection<TblJobWorkCondition> TblJobWorkConditions { get; set; }
        public virtual ICollection<TblPerson> TblPeople { get; set; }
    }
}
