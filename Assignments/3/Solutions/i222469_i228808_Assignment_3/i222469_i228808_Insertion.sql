

INSERT INTO Colleges VALUES (1, 'Tech University', 'Springfield', 'Ohio', 'USA', '45502', '937-555-0123', '123 College St.', 'info@techuniversity.com');
INSERT INTO Colleges VALUES (2, 'Metro State College', 'Denver', 'Colorado', 'USA', '80014', '303-555-0182', '456 University Blvd.', 'contact@metrostate.edu');
INSERT INTO Colleges VALUES (3, 'Harbor College', 'Harbor City', 'California', 'USA', '90710', '310-555-0191', '789 College Rd.', 'admin@harborcollege.edu');
INSERT INTO Colleges VALUES (4, 'Greenwood College', 'Greenwood', 'Mississippi', 'USA', '38930', '662-555-0145', '101 Academy Ave.', 'support@greenwood.edu');
INSERT INTO Colleges VALUES (5, 'Hill Valley University', 'Hill Valley', 'California', 'USA', '95420', '707-555-0154', '234 University Dr.', 'hvuniversity@edu.com');
INSERT INTO Colleges VALUES (6, 'Riverside Institute', 'Riverside', 'New Jersey', 'USA', '08075', '856-555-0163', '345 College Way', 'info@riversideinstitute.edu');
INSERT INTO Colleges VALUES (7, 'East Coast College', 'Richmond', 'Virginia', 'USA', '23223', '804-555-0172', '567 University Ln.', 'contact@eastcoastcollege.edu');
INSERT INTO Colleges VALUES (8, 'Northern University', 'Fargo', 'North Dakota', 'USA', '58102', '701-555-0181', '678 College Park', 'admin@northernuniversity.edu');
INSERT INTO Colleges VALUES (9, 'Southern College', 'Tampa', 'Florida', 'USA', '33620', '813-555-0190', '789 Academy Blvd.', 'info@southerncollege.edu');
INSERT INTO Colleges VALUES (10, 'West Coast University', 'Los Angeles', 'California', 'USA', '90007', '213-555-0200', '890 University Ave.', 'contact@westcoastuniversity.edu');

INSERT INTO Departments VALUES (1, 'Computer Science', 101, 1, 'Building A, Room 101');
INSERT INTO Departments VALUES (2, 'Mechanical Engineering', 102, 1, 'Building B, Room 201');
INSERT INTO Departments VALUES (3, 'Electrical Engineering', 103, 2, 'Building C, Room 301');
INSERT INTO Departments VALUES (4, 'Civil Engineering', 104, 2, 'Building D, Room 401');
INSERT INTO Departments VALUES (5, 'Business Administration', 105, 3, 'Building E, Room 501');
INSERT INTO Departments VALUES (6, 'Biochemistry', 106, 3, 'Building F, Room 601');
INSERT INTO Departments VALUES (7, 'Physics', 107, 4, 'Building G, Room 701');
INSERT INTO Departments VALUES (8, 'History', 108, 4, 'Building H, Room 801');
INSERT INTO Departments VALUES (9, 'English Literature', 109, 5, 'Building I, Room 901');
INSERT INTO Departments VALUES (10, 'Mathematics', 110, 5, 'Building J, Room 1001');


INSERT INTO Faculty VALUES (101, 1, 75000.00);
INSERT INTO Faculty VALUES (102, 2, 70000.00);
INSERT INTO Faculty VALUES (103, 3, 72000.00);
INSERT INTO Faculty VALUES (104, 4, 68000.00);
INSERT INTO Faculty VALUES (105, 5, 65000.00);
INSERT INTO Faculty VALUES (106, 6, 62000.00);
INSERT INTO Faculty VALUES (107, 7, 61000.00);
INSERT INTO Faculty VALUES (108, 8, 63000.00);
INSERT INTO Faculty VALUES (109, 9, 64000.00);
INSERT INTO Faculty VALUES (110, 10, 66000.00);

INSERT INTO Users VALUES (1, 'John', 'Doe', 'john.doe@example.com', '555-1234', 'johndoe', 'password123');
INSERT INTO Users VALUES (2, 'Jane', 'Smith', 'jane.smith@example.com', '555-5678', 'janesmith', 'password456');
INSERT INTO Users VALUES (3, 'Alice', 'Johnson', 'alice.johnson@example.com', '555-9012', 'alicejohnson', 'password789');
INSERT INTO Users VALUES (4, 'Bob', 'Williams', 'bob.williams@example.com', '555-3456', 'bobwilliams', 'password012');
INSERT INTO Users VALUES (5, 'Carol', 'Brown', 'carol.brown@example.com', '555-7890', 'carolbrown', 'password345');
INSERT INTO Users VALUES (6, 'David', 'Jones', 'david.jones@example.com', '555-1235', 'davidjones', 'password678');
INSERT INTO Users VALUES (7, 'Eva', 'Miller', 'eva.miller@example.com', '555-5679', 'evamiller', 'password901');
INSERT INTO Users VALUES (8, 'Frank', 'Davis', 'frank.davis@example.com', '555-9013', 'frankdavis', 'password234');
INSERT INTO Users VALUES (9, 'Grace', 'Garcia', 'grace.garcia@example.com', '555-3457', 'gracegarcia', 'password567');
INSERT INTO Users VALUES (10, 'Henry', 'Wilson', 'henry.wilson@example.com', '555-7891', 'henrywilson', 'password890');

INSERT INTO SystemAdministrators VALUES (1, 'Super Admin', 1);
INSERT INTO SystemAdministrators VALUES (2, 'Admin', 2);
INSERT INTO SystemAdministrators VALUES (3, 'Admin', 3);
INSERT INTO SystemAdministrators VALUES (4, 'Admin', 4);
INSERT INTO SystemAdministrators VALUES (5, 'Admin', 5);
INSERT INTO SystemAdministrators VALUES (6, 'Admin', 6);
INSERT INTO SystemAdministrators VALUES (7, 'Admin', 7);
INSERT INTO SystemAdministrators VALUES (8, 'Admin', 8);
INSERT INTO SystemAdministrators VALUES (9, 'Admin', 9);
INSERT INTO SystemAdministrators VALUES (10, 'Admin', 10);

INSERT INTO CollegeStaff VALUES (1, 1);
INSERT INTO CollegeStaff VALUES (2, 2);
INSERT INTO CollegeStaff VALUES (3, 3);
INSERT INTO CollegeStaff VALUES (4, 4);
INSERT INTO CollegeStaff VALUES (5, 5);
INSERT INTO CollegeStaff VALUES (6, 6);
INSERT INTO CollegeStaff VALUES (7, 7);
INSERT INTO CollegeStaff VALUES (8, 8);
INSERT INTO CollegeStaff VALUES (9, 9);
INSERT INTO CollegeStaff VALUES (10, 10);

INSERT INTO Courses VALUES (1, 'Introduction to Programming', 'CS101', 'Learn the basics of programming.', 1, 101, 3, NULL);
INSERT INTO Courses VALUES (2, 'Algorithms', 'CS201', 'Study of algorithms', 1, 101, 3, 1);
INSERT INTO Courses VALUES (3, 'Data Structures', 'CS202', 'Organizing data for efficient access and modification.', 1, 101, 3, 1);
INSERT INTO Courses VALUES (4, 'Machine Learning', 'CS303', 'Introduction to machine learning concepts and algorithms.', 1, 101, 4, 2);
INSERT INTO Courses VALUES (5, 'Thermodynamics', 'ME101', 'Fundamentals of thermodynamics.', 2, 102, 3, NULL);
INSERT INTO Courses VALUES (6, 'Fluid Mechanics', 'ME201', 'Study of fluids in motion.', 2, 102, 3, 5);
INSERT INTO Courses VALUES (7, 'Circuit Analysis', 'EE101', 'Introduction to electrical circuits.', 3, 103, 3, NULL);
INSERT INTO Courses VALUES (8, 'Electronics', 'EE201', 'Study of electronic components.', 3, 103, 3, 7);
INSERT INTO Courses VALUES (9, 'Statics', 'CE101', 'Fundamentals of statics in engineering.', 4, 104, 3, NULL);
INSERT INTO Courses VALUES (10, 'Dynamics', 'CE201', 'Study of forces and motion.', 4, 104, 3, 9);


INSERT INTO CourseSchedule VALUES (1, 1, 101, 'Monday', '09:00:00', '11:00:00');
INSERT INTO CourseSchedule VALUES (2, 2, 101, 'Wednesday', '10:00:00', '12:00:00');
INSERT INTO CourseSchedule VALUES (3, 3, 101, 'Friday', '13:00:00', '15:00:00');
INSERT INTO CourseSchedule VALUES (4, 4, 101, 'Tuesday', '14:00:00', '16:00:00');
INSERT INTO CourseSchedule VALUES (5, 5, 102, 'Monday', '09:00:00', '11:00:00');
INSERT INTO CourseSchedule VALUES (6, 6, 102, 'Wednesday', '10:00:00', '12:00:00');
INSERT INTO CourseSchedule VALUES (7, 7, 103, 'Friday', '13:00:00', '15:00:00');
INSERT INTO CourseSchedule VALUES (8, 8, 103, 'Tuesday', '14:00:00', '16:00:00');
INSERT INTO CourseSchedule VALUES (9, 9, 104, 'Thursday', '09:00:00', '11:00:00');
INSERT INTO CourseSchedule VALUES (10, 10, 104, 'Thursday', '12:00:00', '14:00:00');

INSERT INTO Programs VALUES (1, 'Computer Science', '4 years', 'BSc', 'Undergraduate degree in computer science.', 120);
INSERT INTO Programs VALUES (2, 'Mechanical Engineering', '4 years', 'BSc', 'Undergraduate degree in mechanical engineering.', 120);
INSERT INTO Programs VALUES (3, 'Electrical Engineering', '4 years', 'BSc', 'Undergraduate degree in electrical engineering.', 120);
INSERT INTO Programs VALUES (4, 'Civil Engineering', '4 years', 'BSc', 'Undergraduate degree in civil engineering.', 120);
INSERT INTO Programs VALUES (5, 'Business Administration', '3 years', 'BBA', 'Undergraduate degree in business administration.', 90);
INSERT INTO Programs VALUES (6, 'Biochemistry', '4 years', 'BSc', 'Undergraduate degree in biochemistry.', 120);
INSERT INTO Programs VALUES (7, 'Physics', '4 years', 'BSc', 'Undergraduate degree in physics.', 120);
INSERT INTO Programs VALUES (8, 'History', '3 years', 'BA', 'Undergraduate degree in history.', 90);
INSERT INTO Programs VALUES (9, 'English Literature', '3 years', 'BA', 'Undergraduate degree in English literature.', 90);
INSERT INTO Programs VALUES (10, 'Mathematics', '4 years', 'BSc', 'Undergraduate degree in mathematics.', 120);

INSERT INTO Students VALUES (1, '1995-04-12', '2013', 1);
INSERT INTO Students VALUES (2, '1996-05-23', '2014', 1);
INSERT INTO Students VALUES (3, '1997-06-15', '2015', 2);
INSERT INTO Students VALUES (4, '1998-07-08', '2016', 2);
INSERT INTO Students VALUES (5, '1999-08-19', '2017', 3);
INSERT INTO Students VALUES (6, '2000-09-20', '2018', 3);
INSERT INTO Students VALUES (7, '2001-10-22', '2019', 4);
INSERT INTO Students VALUES (8, '2002-11-30', '2020', 4);
INSERT INTO Students VALUES (9, '2003-12-14', '2021', 5);
INSERT INTO Students VALUES (10, '2004-01-16', '2022', 5);

INSERT INTO Enrollment VALUES (1, 1, '2022-08-25', 'Active', 'A', 1);
INSERT INTO Enrollment VALUES (2, 2, '2022-08-25', 'Active', 'B', 2);
INSERT INTO Enrollment VALUES (3, 3, '2022-08-25', 'Active', 'C', 3);
INSERT INTO Enrollment VALUES (4, 4, '2022-08-25', 'Active', 'D', 4);
INSERT INTO Enrollment VALUES (5, 5, '2022-08-25', 'Active', 'E', 5);
INSERT INTO Enrollment VALUES (6, 6, '2022-08-25', 'Active', 'F', 6);
INSERT INTO Enrollment VALUES (7, 7, '2022-08-25', 'Active', 'A', 7);
INSERT INTO Enrollment VALUES (8, 8, '2022-08-25', 'Active', 'B', 8);
INSERT INTO Enrollment VALUES (9, 9, '2022-08-25', 'Active', 'C', 9);
INSERT INTO Enrollment VALUES (10, 10, '2022-08-25', 'Active', 'D', 10);

INSERT INTO ProgramCourses VALUES (1, 1);
INSERT INTO ProgramCourses VALUES (1, 2);
INSERT INTO ProgramCourses VALUES (1, 3);
INSERT INTO ProgramCourses VALUES (1, 4);
INSERT INTO ProgramCourses VALUES (2, 5);
INSERT INTO ProgramCourses VALUES (2, 6);
INSERT INTO ProgramCourses VALUES (3, 7);
INSERT INTO ProgramCourses VALUES (3, 8);
INSERT INTO ProgramCourses VALUES (4, 9);
INSERT INTO ProgramCourses VALUES (4, 10);

INSERT INTO ProgramFacultyAssignments VALUES (1, 1, 101);
INSERT INTO ProgramFacultyAssignments VALUES (2, 1, 101);
INSERT INTO ProgramFacultyAssignments VALUES (3, 2, 102);
INSERT INTO ProgramFacultyAssignments VALUES (4, 2, 102);
INSERT INTO ProgramFacultyAssignments VALUES (5, 3, 103);
INSERT INTO ProgramFacultyAssignments VALUES (6, 3, 103);
INSERT INTO ProgramFacultyAssignments VALUES (7, 4, 104);
INSERT INTO ProgramFacultyAssignments VALUES (8, 4, 104);
INSERT INTO ProgramFacultyAssignments VALUES (9, 5, 105);
INSERT INTO ProgramFacultyAssignments VALUES (10, 5, 105);

INSERT INTO ProgramEnrollment VALUES (1, 1);
INSERT INTO ProgramEnrollment VALUES (2, 1);
INSERT INTO ProgramEnrollment VALUES (3, 2);
INSERT INTO ProgramEnrollment VALUES (4, 2);
INSERT INTO ProgramEnrollment VALUES (5, 3);
INSERT INTO ProgramEnrollment VALUES (6, 3);
INSERT INTO ProgramEnrollment VALUES (7, 4);
INSERT INTO ProgramEnrollment VALUES (8, 4);
INSERT INTO ProgramEnrollment VALUES (9, 5);
INSERT INTO ProgramEnrollment VALUES (10, 5);

INSERT INTO FacultyAssignments VALUES (1, 101, 1, '08:00:00', '10:00:00', 1);
INSERT INTO FacultyAssignments VALUES (2, 102, 2, '10:00:00', '12:00:00', 2);
INSERT INTO FacultyAssignments VALUES (3, 103, 3, '12:00:00', '14:00:00', 3);
INSERT INTO FacultyAssignments VALUES (4, 104, 4, '14:00:00', '16:00:00', 4);
INSERT INTO FacultyAssignments VALUES (5, 105, 5, '08:00:00', '10:00:00', 5);
INSERT INTO FacultyAssignments VALUES (6, 106, 6, '10:00:00', '12:00:00', 6);
INSERT INTO FacultyAssignments VALUES (7, 107, 7, '12:00:00', '14:00:00', 7);
INSERT INTO FacultyAssignments VALUES (8, 108, 8, '14:00:00', '16:00:00', 8);
INSERT INTO FacultyAssignments VALUES (9, 109, 9, '08:00:00', '10:00:00', 9);
INSERT INTO FacultyAssignments VALUES (10, 110, 10, '10:00:00', '12:00:00', 2);

INSERT INTO DailyFacultyAssignments VALUES (1);
INSERT INTO DailyFacultyAssignments VALUES (3);
INSERT INTO DailyFacultyAssignments VALUES (5);
INSERT INTO DailyFacultyAssignments VALUES (7);
INSERT INTO DailyFacultyAssignments VALUES (9);
INSERT INTO DailyFacultyAssignments VALUES (2);
INSERT INTO DailyFacultyAssignments VALUES (4);
INSERT INTO DailyFacultyAssignments VALUES (6);
INSERT INTO DailyFacultyAssignments VALUES (8);
INSERT INTO DailyFacultyAssignments VALUES (10);

INSERT INTO MonthlyFacultyAssignments VALUES (1, '08:00:00', '10:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (3, '12:00:00', '14:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (5, '08:00:00', '10:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (7, '12:00:00', '14:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (9, '08:00:00', '10:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (2, '10:00:00', '12:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (4, '14:00:00', '16:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (6, '10:00:00', '12:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (8, '14:00:00', '16:00:00', '1,15');
INSERT INTO MonthlyFacultyAssignments VALUES (10, '10:00:00', '12:00:00', '1,15');

INSERT INTO WeeklyFacultyAssignments VALUES (1, '08:00:00', '10:00:00', 'Monday,Wednesday');
INSERT INTO WeeklyFacultyAssignments VALUES (2, '10:00:00', '12:00:00', 'Tuesday,Thursday');
INSERT INTO WeeklyFacultyAssignments VALUES (3, '12:00:00', '14:00:00', 'Wednesday,Friday');
INSERT INTO WeeklyFacultyAssignments VALUES (4, '14:00:00', '16:00:00', 'Monday,Wednesday');
INSERT INTO WeeklyFacultyAssignments VALUES (5, '16:00:00', '18:00:00', 'Tuesday,Thursday');
INSERT INTO WeeklyFacultyAssignments VALUES (6, '08:00:00', '10:00:00', 'Wednesday,Friday');
INSERT INTO WeeklyFacultyAssignments VALUES (7, '10:00:00', '12:00:00', 'Monday,Wednesday');
INSERT INTO WeeklyFacultyAssignments VALUES (8, '12:00:00', '14:00:00', 'Tuesday,Thursday');
INSERT INTO WeeklyFacultyAssignments VALUES (9, '14:00:00', '16:00:00', 'Wednesday,Friday');
INSERT INTO WeeklyFacultyAssignments VALUES (10, '16:00:00', '18:00:00', 'Monday,Wednesday');

INSERT INTO CourseEnrollments VALUES (1, 1);
INSERT INTO CourseEnrollments VALUES (2, 2);
INSERT INTO CourseEnrollments VALUES (3, 3);
INSERT INTO CourseEnrollments VALUES (4, 4);
INSERT INTO CourseEnrollments VALUES (5, 5);
INSERT INTO CourseEnrollments VALUES (6, 6);
INSERT INTO CourseEnrollments VALUES (7, 7);
INSERT INTO CourseEnrollments VALUES (8, 8);
INSERT INTO CourseEnrollments VALUES (9, 9);
INSERT INTO CourseEnrollments VALUES (10, 10);

