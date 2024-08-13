SELECT * FROM Colleges;
SELECT * FROM Departments;
SELECT * FROM Faculty;
SELECT * FROM Users;
SELECT * FROM SystemAdministrators;
SELECT * FROM CollegeStaff;
SELECT * FROM Courses;
SELECT * FROM CourseSchedule;
SELECT * FROM Programs;
SELECT * FROM Students;
SELECT * FROM Enrollment;
SELECT * FROM ProgramCourses;
SELECT * FROM ProgramFacultyAssignments;
SELECT * FROM ProgramEnrollment;
SELECT * FROM FacultyAssignments;
SELECT * FROM DailyFacultyAssignments;
SELECT * FROM MonthlyFacultyAssignments;
SELECT * FROM WeeklyFacultyAssignments;
SELECT * FROM CourseEnrollments;

--departments within a college
SELECT department_name FROM Departments WHERE college_id = 1;  

--list of courses with their corresponding college names
SELECT c.course_name, co.college_name FROM Courses c
JOIN Departments d ON c.department_id = d.department_id
JOIN Colleges co ON d.college_id = co.college_id;

--number of students enrolled in each department
SELECT d.department_name, COUNT(s.student_id) AS student_count FROM Students s
JOIN Departments d ON s.department_id = d.department_id
GROUP BY d.department_name;

-- the courses and the number of credits for each course in the 'Computer Science' department.
SELECT course_name, credits FROM Courses 
WHERE department_id = (SELECT department_id FROM Departments WHERE department_name = 'Computer Science');

-- update
UPDATE Users SET phone_number = '555-9999' WHERE user_id = 2;  
SELECT * FROM Users;

-- system administrators and their associated colleges.
SELECT u.first_name, u.last_name, co.college_name FROM SystemAdministrators sa
JOIN Users u ON sa.admin_id = u.user_id
JOIN Colleges co ON sa.college_id = co.college_id;

-- courses without pre req
SELECT course_name FROM Courses WHERE prerequisite_course_id IS NULL;

-- all staff members and the colleges they belong to.
SELECT u.first_name, u.last_name, co.college_name FROM CollegeStaff cs
JOIN Users u ON cs.staff_id = u.user_id
JOIN Colleges co ON cs.college_id = co.college_id;

-- all students born after a specific date (e.g., '2000-01-01').
SELECT user_id, first_name, last_name, date_of_birth FROM Students s
JOIN Users u ON s.student_id = u.user_id
WHERE date_of_birth > '2000-01-01';

--top 3 highest paid faculty members in each department
SELECT F1.department_id, F1.faculty_id, F1.salary
FROM Faculty F1
WHERE (
    SELECT COUNT(DISTINCT F2.salary)
    FROM Faculty F2
    WHERE F2.salary >= F1.salary AND F1.department_id = F2.department_id
) <= 3
ORDER BY F1.department_id, F1.salary DESC;

--the course schedule for a specific day (e.g., 'Monday').
SELECT course_id, faculty_id, start_time, end_time FROM CourseSchedule
WHERE day_of_week = 'Monday';

-- highest paid faculty member in each department
SELECT department_id, faculty_id, salary
FROM Faculty F1
WHERE salary = (
    SELECT MAX(salary)
    FROM Faculty F2
    WHERE F1.department_id = F2.department_id
);

--faculty who teach more than 3 courses.
SELECT u.first_name, u.last_name, COUNT(co.course_id) AS courses_taught
FROM Faculty f
JOIN Users u ON f.faculty_id = u.user_id
JOIN Courses co ON f.faculty_id = co.faculty_id
GROUP BY f.faculty_id, u.first_name, u.last_name
HAVING COUNT(co.course_id) > 3;

-- number of courses offered by each department
SELECT D.department_id, D.department_name, COUNT(C.course_id) AS num_courses
FROM Departments D
LEFT JOIN Courses C ON D.department_id = C.department_id
GROUP BY D.department_id, D.department_name;

--all faculty who have not been assigned to any course
SELECT u.first_name, u.last_name
FROM Users u
JOIN Faculty f ON u.user_id = f.faculty_id
LEFT JOIN Courses c ON f.faculty_id = c.faculty_id
WHERE c.course_id IS NULL;








