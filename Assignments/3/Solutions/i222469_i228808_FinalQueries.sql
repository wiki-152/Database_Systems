--1-- 

SELECT 
    u.first_name, 
    u.last_name, 
    c.college_name, 
    co.course_name,
    d.department_name,
    e.enrollment_date
FROM 
    Students s
JOIN 
    Users u ON s.student_id = u.user_id
JOIN 
    Enrollment e ON s.student_id = e.student_id
	JOIN CourseEnrollments ce on ce.enrollment_id=e.enrollment_id
JOIN 
    Courses co ON co.course_id = ce.course_id
JOIN 
    Departments d ON co.department_id = d.department_id
JOIN 
    Colleges c ON d.college_id = c.college_id
JOIN 
    Faculty f ON co.faculty_id = f.faculty_id
JOIN 
    FacultyAssignments fa ON f.faculty_id = fa.faculty_id
LEFT JOIN 
    DailyFacultyAssignments dfa ON fa.assignment_id = dfa.assignment_id
LEFT JOIN 
    WeeklyFacultyAssignments wfa ON fa.assignment_id = wfa.assignment_id
LEFT JOIN 
    MonthlyFacultyAssignments mfa ON fa.assignment_id = mfa.assignment_id
WHERE 
    c.college_id IN (1,2,3,4,5) OR c.college_name = 'Tech University';


--2--
SELECT 
    c.course_name,
    c.course_code,
    c.description,
    d.department_name,
    col.college_name,
    cs.day_of_week,
    cs.start_time,
    cs.end_time,
    COALESCE(dfa.assignment_id, wfa.assignment_id, mfa.assignment_id) AS assignment_type
FROM 
    Courses c
JOIN 
    Departments d ON c.department_id = d.department_id
JOIN 
    Colleges col ON d.college_id = col.college_id
JOIN 
    CourseSchedule cs ON c.course_id = cs.course_id
LEFT JOIN 
    FacultyAssignments fa ON cs.faculty_id = fa.faculty_id
LEFT JOIN 
    DailyFacultyAssignments dfa ON fa.assignment_id = dfa.assignment_id
LEFT JOIN 
    WeeklyFacultyAssignments wfa ON fa.assignment_id = wfa.assignment_id
LEFT JOIN 
    MonthlyFacultyAssignments mfa ON fa.assignment_id = mfa.assignment_id
WHERE 
    d.department_id = 1;  -- Assuming you want to list courses from the department with ID 1

--3--
SELECT 
    u.first_name,
    u.last_name,
    co.course_name,
    co.description,
    e.enrollment_date,
    e.grade,
    (CASE 
        WHEN dfa.assignment_id IS NOT NULL THEN 'Daily'
        WHEN wfa.assignment_id IS NOT NULL THEN 'Weekly'
        WHEN mfa.assignment_id IS NOT NULL THEN 'Monthly'
        ELSE 'No specific frequency'
     END) AS Assignment_Frequency
FROM 
    Students s
JOIN 
    Users u ON s.student_id = u.user_id
JOIN 
    Enrollment e ON s.student_id = e.student_id
JOIN
CourseEnrollments ce on ce.enrollment_id=e.enrollment_id
JOIN
    Courses co ON co.course_id = ce.course_id
JOIN 
    Faculty f ON co.faculty_id = f.faculty_id
JOIN 
    FacultyAssignments fa ON f.faculty_id = fa.faculty_id
LEFT JOIN 
    DailyFacultyAssignments dfa ON fa.assignment_id = dfa.assignment_id
LEFT JOIN 
    WeeklyFacultyAssignments wfa ON fa.assignment_id = wfa.assignment_id
LEFT JOIN 
    MonthlyFacultyAssignments mfa ON fa.assignment_id = mfa.assignment_id
WHERE 
    co.course_name IN ('Introduction to Programming', 'Algorithms'); -- Example course names


--4--
-- Listing all courses and faculty assignments between 10:00 AM and 12:00 PM
-- Courses and their schedules
SELECT 
    co.course_name,
    cs.day_of_week,
    cs.start_time,
    cs.end_time,
    f.faculty_id,
    d.department_name,
    c.college_name
FROM 
    Courses co
JOIN 
    CourseSchedule cs ON co.course_id = cs.course_id
JOIN 
    Faculty f ON co.faculty_id = f.faculty_id
JOIN 
    Departments d ON co.department_id = d.department_id
JOIN 
    Colleges c ON d.college_id = c.college_id
WHERE 
    cs.start_time <= '12:00:00' AND cs.end_time >= '10:00:00'

UNION ALL

-- Faculty assignments (daily, weekly, and monthly)
SELECT 
    co.course_name,
    'Varies' AS day_of_week, -- Since specific days might not be known
    fa.start_time,
    fa.end_time,
    f.faculty_id,
    d.department_name,
    c.college_name
FROM 
    FacultyAssignments fa
JOIN 
    Faculty f ON fa.faculty_id = f.faculty_id
JOIN 
    Departments d ON fa.department_id = d.department_id
JOIN 
    Colleges c ON d.college_id = c.college_id
JOIN 
    Courses co ON f.faculty_id = co.faculty_id
WHERE 
    fa.start_time <= '12:00:00' AND fa.end_time >= '10:00:00'
ORDER BY 
    college_name, department_name, course_name;

--5--
SELECT 
    f1.faculty_id,
    f1.start_time,
    f1.end_time,
    d1.department_name AS first_department,
    d2.department_name AS second_department
FROM 
    FacultyAssignments f1
JOIN 
    FacultyAssignments f2 ON f1.faculty_id = f2.faculty_id AND f1.assignment_id <> f2.assignment_id
JOIN 
    Departments d1 ON f1.department_id = d1.department_id
JOIN 
    Departments d2 ON f2.department_id = d2.department_id
WHERE 
    f1.start_time < f2.end_time AND f1.end_time > f2.start_time AND d1.department_id <> d2.department_id
ORDER BY 
    f1.faculty_id, f1.start_time;

--6--
SELECT TOP 1 
    f.faculty_id,
    COUNT(fa.assignment_id) AS assignment_count,
    d.department_name
FROM 
    FacultyAssignments fa
JOIN 
    Faculty f ON fa.faculty_id = f.faculty_id
JOIN 
    Departments d ON fa.department_id = d.department_id
GROUP BY 
    f.faculty_id, d.department_name
ORDER BY 
    assignment_count ASC;


--7--
SELECT TOP 1 
    f.faculty_id,
    COUNT(fa.assignment_id) AS assignment_count,
    d.department_name
FROM 
    FacultyAssignments fa
JOIN 
    Faculty f ON fa.faculty_id = f.faculty_id
JOIN 
    Departments d ON fa.department_id = d.department_id
GROUP BY 
    f.faculty_id, d.department_name
ORDER BY 
    assignment_count DESC;

--8--
SELECT 
    s.student_id,
    u.first_name,
    u.last_name,
    c.course_id,
    c.course_name,
    COUNT(e.enrollment_id) AS times_enrolled
FROM 
    Enrollment e
JOIN 
    Students s ON e.student_id = s.student_id
JOIN 
    Users u ON s.student_id = u.user_id
	JOIN CourseEnrollments ce on ce.enrollment_id=e.enrollment_id
JOIN 
    Courses c ON c.course_id = ce.course_id
GROUP BY 
    s.student_id, u.first_name, u.last_name, c.course_id, c.course_name
HAVING 
    COUNT(e.enrollment_id) > 1
ORDER BY 
    times_enrolled DESC, s.student_id;


--9--

	SELECT 
    s.student_id,
    u.first_name,
    u.last_name,
    COUNT(DISTINCT c.course_id) AS number_of_courses,
    COUNT(e.enrollment_id) AS total_enrollments
FROM 
    Students s
JOIN 
    Users u ON s.student_id = u.user_id
JOIN 
    Enrollment e ON s.student_id = e.student_id
JOIN 
    CourseEnrollments ce ON e.enrollment_id = ce.enrollment_id
JOIN 
    Courses c ON ce.course_id = c.course_id
GROUP BY 
    s.student_id, u.first_name, u.last_name
HAVING 
    COUNT(DISTINCT c.course_id) > 1 AND COUNT(e.enrollment_id) > 1
ORDER BY 
    total_enrollments DESC;
