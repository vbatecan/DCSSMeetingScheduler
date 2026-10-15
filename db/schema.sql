CREATE DATABASE IF NOT EXISTS dcss_db;
USE dcss_db;

DROP TABLE IF EXISTS appointments;
DROP TABLE IF EXISTS faculty_availability;
DROP TABLE IF EXISTS users;

CREATE TABLE users (
user_id INT AUTO_INCREMENT PRIMARY KEY,
ue_email VARCHAR(100) NOT NULL UNIQUE,
user_password VARCHAR(64) NOT NULL,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
role ENUM('Admin','Faculty','Student') NOT NULL,
id_number VARCHAR(20) NULL,
program_or_dept VARCHAR(50) NULL,
is_active BOOLEAN NOT NULL DEFAULT 1,
must_change_password BOOLEAN NOT NULL DEFAULT 1,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE faculty_availability (
availability_id INT AUTO_INCREMENT PRIMARY KEY,
faculty_id INT NOT NULL,
days ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday', 'Sunday') NOT NULL,
start_time TIME NOT NULL,
end_time TIME NOT NULL,
location VARCHAR(100) NULL,
CONSTRAINT fk_avail_faculty FOREIGN KEY (faculty_id)
REFERENCES users(user_id) ON DELETE CASCADE
);

CREATE TABLE appointments (
appointment_id INT AUTO_INCREMENT PRIMARY KEY,
student_id INT NOT NULL,
faculty_id INT NOT NULL,
meeting_datetime DATETIME NOT NULL,
purpose VARCHAR(255) NOT NULL,
status ENUM('Pending','Approved','Declined','Completed','Cancelled')
NOT NULL DEFAULT 'Pending',
faculty_remarks VARCHAR(255) NULL,
is_student_notified BOOLEAN NOT NULL DEFAULT 1,
is_faculty_notified BOOLEAN NOT NULL DEFAULT 0,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT fk_appt_student FOREIGN KEY (student_id) REFERENCES users(user_id),
CONSTRAINT fk_appt_faculty FOREIGN KEY (faculty_id) REFERENCES users(user_id)
);

-- DUMMY DATA (all passwords below = "password123")
INSERT INTO users (ue_email, user_password, first_name, last_name, role, id_number, program_or_dept, must_change_password) VALUES
('Camacho.Paul@ue.edu.ph', ('password123'), 'Paul', 'Camacho', 'Admin', 'EMP-0001', 'DCSS', 0),
('Batecan.Vince@ue.edu.ph', ('password123'), 'Vince', 'Batecan', 'Faculty', 'EMP-1001', 'DCSS', 0),
('Raymundo.Kirby@ue.edu.ph', ('password123,'), 'Kirby', 'Raymundo', 'Faculty', 'EMP-1002', 'DCSS', 0),
('Reyes.Jane@ue.edu.ph', ('password123'), 'Jane', 'Reyes', 'Student', '2022-0001', 'BSCS', 0),
('Pastrana.Kyle@ue.edu.ph', ('password123'), 'Kyle', 'Pastrana', 'Student', '2022-0002', 'BSIT', 0);

INSERT INTO faculty_availability (faculty_id, days, start_time, end_time, location) VALUES
(2, 'Monday', '09:00:00', '11:00:00', 'DCSS Faculty Room'),
(2, 'Wednesday', '13:00:00', '15:00:00', 'DCSS Faculty Room'),
(3, 'Tuesday', '10:00:00', '12:00:00', 'Online (MS Teams)'),
(3, 'Thursday', '14:00:00', '16:00:00', 'Room 305');

INSERT INTO appointments (student_id, faculty_id, meeting_datetime, purpose, status, is_student_notified, is_faculty_notified) VALUES
(4, 2, '2026-10-19 09:00:00', 'Thesis topic consultation', 'Pending', 1, 0),
(5, 3, '2026-10-20 10:00:00', 'Grade clarification', 'Approved', 0, 1),
(4, 3, '2026-10-22 14:00:00', 'Project advising', 'Declined', 0, 1);