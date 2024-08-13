-- Colleges table
CREATE TABLE Colleges (
    college_id INT PRIMARY KEY,
    college_name VARCHAR(255),
    city VARCHAR(255),
	state VARCHAR(255),
    country VARCHAR(255),
    postal_code VARCHAR(50),
    landline VARCHAR(255),
    street VARCHAR(255),
    email VARCHAR(255)
);

-- Departments table
CREATE TABLE Departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(255),
    department_head_id INT,
	college_id INT,
    office_location VARCHAR(255)
);

-- Faculty table
CREATE TABLE Faculty (
    faculty_id INT PRIMARY KEY,
    department_id INT,
    salary DECIMAL(10, 2)
);

-- Users table
CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(50),
    username VARCHAR(255),
    pass VARCHAR(255)
);

-- SystemAdministrators table
CREATE TABLE SystemAdministrators (
    admin_id INT PRIMARY KEY,
    admin_privilege VARCHAR(255),
    college_id INT
);

-- CollegeStaff table
CREATE TABLE CollegeStaff (
    staff_id INT PRIMARY KEY,
    college_id INT
);

-- Courses table
CREATE TABLE Courses (
    course_id INT PRIMARY KEY,
    course_name VARCHAR(255),
	course_code VARCHAR(50),
    description TEXT,
    department_id INT,
	faculty_id INT,
    credits INT,
    prerequisite_course_id INT
);

-- CourseSchedule table
CREATE TABLE CourseSchedule (
    schedule_id INT PRIMARY KEY,
    course_id INT,
    faculty_id INT,
    day_of_week VARCHAR(50),
    start_time TIME,
    end_time TIME
);

-- Programs table
CREATE TABLE Programs (
    program_id INT PRIMARY KEY,
    program_name VARCHAR(255),
	duration VARCHAR(255),
    degree_type VARCHAR(50),
	description TEXT,
	credits_required INT,
);

-- Students table
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    date_of_birth DATE,
    batch VARCHAR(50),
    department_id INT
);

-- Enrollment table
CREATE TABLE Enrollment (
    enrollment_id INT PRIMARY KEY,
    student_id INT,
    enrollment_date DATE,
	status VARCHAR(50),
    grade VARCHAR(2),
	staff_id INT
);

-- ProgramCourses table
CREATE TABLE ProgramCourses (
    program_id INT,
    course_id INT,
    PRIMARY KEY (program_id, course_id)
);

-- ProgramFacultyAssignments table
CREATE TABLE ProgramFacultyAssignments (
    program_faculty_id INT PRIMARY KEY,
    program_id INT,
    faculty_id INT
);

-- ProgramEnrollment table
CREATE TABLE ProgramEnrollment (
    enrollment_id INT,
    program_id INT,
    PRIMARY KEY (enrollment_id, program_id)
);

-- FacultyAssignments table (representing all types of assignments; daily, weekly, and monthly)
CREATE TABLE FacultyAssignments (
    assignment_id INT PRIMARY KEY,
    faculty_id INT,
    department_id INT,
    start_time TIME,
    end_time TIME,
    CollegeStaff_id INT
);

--Daily
CREATE TABLE DailyFacultyAssignments (
    assignment_id INT PRIMARY KEY
);

-- Monthly
CREATE TABLE MonthlyFacultyAssignments (
    assignment_id INT PRIMARY KEY,
    start_time TIME,
    end_time TIME,
    monthly_days VARCHAR(50)
);

--Weekly
CREATE TABLE WeeklyFacultyAssignments (
    assignment_id INT PRIMARY KEY,
    start_time TIME,
    end_time TIME,
    weekly_days VARCHAR(50)
);

--courseenroll
CREATE TABLE CourseEnrollments (
    enrollment_id INT PRIMARY KEY,
    course_id INT
);


-- FK

ALTER TABLE Departments ADD FOREIGN KEY (college_id) REFERENCES Colleges(college_id);
ALTER TABLE Faculty ADD FOREIGN KEY (department_id) REFERENCES Departments(department_id);
ALTER TABLE SystemAdministrators ADD FOREIGN KEY (admin_id) REFERENCES Users(user_id);
ALTER TABLE SystemAdministrators ADD FOREIGN KEY (college_id) REFERENCES Colleges(college_id);
ALTER TABLE CollegeStaff ADD FOREIGN KEY (staff_id) REFERENCES Users(user_id);
ALTER TABLE CollegeStaff ADD FOREIGN KEY (college_id) REFERENCES Colleges(college_id);
ALTER TABLE Courses ADD FOREIGN KEY (department_id) REFERENCES Departments(department_id);
ALTER TABLE Courses ADD FOREIGN KEY (prerequisite_course_id) REFERENCES Courses(course_id);
ALTER TABLE Courses ADD FOREIGN KEY (faculty_id) REFERENCES Faculty(faculty_id);
ALTER TABLE CourseSchedule ADD FOREIGN KEY (course_id) REFERENCES Courses(course_id);
ALTER TABLE CourseSchedule ADD FOREIGN KEY (faculty_id) REFERENCES Faculty(faculty_id);
ALTER TABLE Students ADD FOREIGN KEY (student_id) REFERENCES Users(user_id);
ALTER TABLE Students ADD FOREIGN KEY (department_id) REFERENCES Departments(department_id);
ALTER TABLE Enrollment ADD FOREIGN KEY (student_id) REFERENCES Students(student_id);
ALTER TABLE Enrollment ADD FOREIGN KEY (staff_id) REFERENCES CollegeStaff(staff_id);
ALTER TABLE ProgramCourses ADD FOREIGN KEY (program_id) REFERENCES Programs(program_id);
ALTER TABLE ProgramCourses ADD FOREIGN KEY (course_id) REFERENCES Courses(course_id);
ALTER TABLE ProgramFacultyAssignments ADD FOREIGN KEY (program_id) REFERENCES Programs(program_id);
ALTER TABLE ProgramFacultyAssignments ADD FOREIGN KEY (faculty_id) REFERENCES Faculty(faculty_id);
ALTER TABLE FacultyAssignments ADD FOREIGN KEY (faculty_id) REFERENCES Faculty(faculty_id);
ALTER TABLE FacultyAssignments ADD FOREIGN KEY (department_id) REFERENCES Departments(department_id);
ALTER TABLE FacultyAssignments ADD FOREIGN KEY (CollegeStaff_id) REFERENCES CollegeStaff(staff_id);


ALTER TABLE ProgramEnrollment ADD FOREIGN KEY (enrollment_id) REFERENCES Enrollment(enrollment_id);
ALTER TABLE ProgramEnrollment ADD FOREIGN KEY (program_id) REFERENCES Programs(program_id);

ALTER TABLE DailyFacultyAssignments ADD FOREIGN KEY (assignment_id) REFERENCES FacultyAssignments(assignment_id);
ALTER TABLE MonthlyFacultyAssignments ADD FOREIGN KEY (assignment_id) REFERENCES FacultyAssignments(assignment_id);
ALTER TABLE WeeklyFacultyAssignments ADD FOREIGN KEY (assignment_id) REFERENCES FacultyAssignments(assignment_id);

ALTER TABLE CourseEnrollments ADD FOREIGN KEY (enrollment_id) REFERENCES Enrollment(enrollment_id);
ALTER TABLE CourseEnrollments ADD FOREIGN KEY (enrollment_id) REFERENCES Courses(course_id);




