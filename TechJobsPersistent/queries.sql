--Part 1
    --Id - int(11)
    --Name - longtext
    --EmployerId - int(11)

--Part 2
    --SELECT Name
    --FROM techJobs.Employers
    --WHERE Location = "St. Louis City";

--Part 3
    --SELECT DISTINCT Name, Description
    --FROM techJobs.Skills
    --INNER JOIN JobSkills ON Skills.Id = JobSkills.SkillId
    --ORDER BY Skills.Name
