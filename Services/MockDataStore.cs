using System;
using System.Collections.Generic;
using System.Linq;
using DCSSMeetingScheduler.Models;

namespace DCSSMeetingScheduler.Services {
    public class MockDataStore : IDataService {
        private static MockDataStore? _instance;
        public static MockDataStore Instance => _instance ??= new MockDataStore();

        private readonly List<User> _users = new();
        private readonly List<MeetingRequest> _meetings = new();
        private readonly List<NotificationItem> _notifications = new();
        private readonly Dictionary<string, FacultyAvailability> _availabilities = new();

        public event EventHandler? DataChanged;

        public MockDataStore() {
            SeedData();
        }

        private void NotifyChange() {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SeedData() {
            // Seed Users: 1 Admin, 4 Faculty, 4 Students
            var admin = new User {
                UserId = "USR-ADM-01",
                FullName = "Engr. Roberto M. Tan",
                Email = "admin.dcss@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Admin,
                Department = "DCSS - Department Chair",
                IdNumber = "EMP-9801",
                ProgramOrTitle = "Associate Professor IV & Department Chair",
                Phone = "0917-555-1122",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-12)
            };

            var f1 = new User {
                UserId = "USR-FAC-01",
                FullName = "Prof. Maria Elena Santos, MSCS",
                Email = "maria.santos@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Faculty,
                Department = "DCSS",
                IdNumber = "EMP-8219",
                ProgramOrTitle = "Associate Professor / Capstone Coordinator",
                Phone = "0918-223-4455",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-10)
            };

            var f2 = new User {
                UserId = "USR-FAC-02",
                FullName = "Dr. Arthur V. Ramos, DIT",
                Email = "arthur.ramos@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Faculty,
                Department = "DCSS",
                IdNumber = "EMP-7643",
                ProgramOrTitle = "Professor / Cybersecurity Lab Head",
                Phone = "0920-334-5566",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-8)
            };

            var f3 = new User {
                UserId = "USR-FAC-03",
                FullName = "Prof. Kristine Mae Reyes, MIT",
                Email = "kristine.reyes@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Faculty,
                Department = "DCSS",
                IdNumber = "EMP-8921",
                ProgramOrTitle = "Assistant Professor / Data Science Adviser",
                Phone = "0922-445-6677",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-6)
            };

            var f4 = new User {
                UserId = "USR-FAC-04",
                FullName = "Engr. Carlo D. Gutierrez, Meng",
                Email = "carlo.gutierrez@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Faculty,
                Department = "DCSS",
                IdNumber = "EMP-9104",
                ProgramOrTitle = "Instructor / Systems Architecture",
                Phone = "0919-556-7788",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-4)
            };

            var s1 = new User {
                UserId = "USR-STU-01",
                FullName = "Juan A. Dela Cruz",
                Email = "juan.delacruz@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Student,
                Department = "DCSS",
                IdNumber = "2023-01452",
                ProgramOrTitle = "BSCS 3-A",
                Phone = "0927-111-2233",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-14)
            };

            var s2 = new User {
                UserId = "USR-STU-02",
                FullName = "Samantha Louise Reyes",
                Email = "samantha.reyes@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Student,
                Department = "DCSS",
                IdNumber = "2023-02119",
                ProgramOrTitle = "BSIT 3-B",
                Phone = "0916-222-3344",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-14)
            };

            var s3 = new User {
                UserId = "USR-STU-03",
                FullName = "Mark Anthony Lim",
                Email = "mark.lim@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Student,
                Department = "DCSS",
                IdNumber = "2024-00912",
                ProgramOrTitle = "BSIT 2-A",
                Phone = "0917-333-4455",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-7)
            };

            var s4 = new User {
                UserId = "USR-STU-04",
                FullName = "Patricia Nicole Gomez",
                Email = "patricia.gomez@ue.edu.ph",
                Password = "password123",
                Role = UserRole.Student,
                Department = "DCSS",
                IdNumber = "2022-03881",
                ProgramOrTitle = "BSCS 4-A",
                Phone = "0928-444-5566",
                Status = AccountStatus.Active,
                CreatedAt = DateTime.Now.AddMonths(-24)
            };

            _users.AddRange(new[] { admin, f1, f2, f3, f4, s1, s2, s3, s4 });

            // Seed Availabilities
            _availabilities[f1.UserId] = new FacultyAvailability {
                FacultyId = f1.UserId,
                AvailableDays = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday },
                StartTime = "09:00 AM",
                EndTime = "03:00 PM",
                MaxMeetingsPerDay = 4,
                PreferredMode = MeetingType.FaceToFace,
                DefaultLocation = "TYK Building, 4th Floor DCSS Faculty Consultation Room",
                OnlineMeetingPlatform = "Google Meet (UE GSuite link will be emailed)",
                ConsultationNotes = "Please submit an outline or topic draft at least 24 hours prior to our consultation session."
            };

            _availabilities[f2.UserId] = new FacultyAvailability {
                FacultyId = f2.UserId,
                AvailableDays = new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Thursday },
                StartTime = "01:00 PM",
                EndTime = "05:00 PM",
                MaxMeetingsPerDay = 3,
                PreferredMode = MeetingType.Online,
                DefaultLocation = "Cybersecurity Research Lab (TYK 412)",
                OnlineMeetingPlatform = "Microsoft Teams / Google Meet",
                ConsultationNotes = "Consultation is strictly for Network Design, Security Audits, and Practicum matters."
            };

            _availabilities[f3.UserId] = new FacultyAvailability {
                FacultyId = f3.UserId,
                AvailableDays = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday },
                StartTime = "10:00 AM",
                EndTime = "04:00 PM",
                MaxMeetingsPerDay = 5,
                PreferredMode = MeetingType.FaceToFace,
                DefaultLocation = "DCSS Faculty Room Desk #7",
                OnlineMeetingPlatform = "Google Meet",
                ConsultationNotes = "For Machine Learning project consultations, bring sample datasets and confusion matrix metrics."
            };

            _availabilities[f4.UserId] = new FacultyAvailability {
                FacultyId = f4.UserId,
                AvailableDays = new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Friday },
                StartTime = "08:30 AM",
                EndTime = "12:30 PM",
                MaxMeetingsPerDay = 3,
                PreferredMode = MeetingType.FaceToFace,
                DefaultLocation = "Embedded Systems Lab (TYK 305)",
                OnlineMeetingPlatform = "Google Meet",
                ConsultationNotes = "Open for Systems Architecture, IoT project advisory, and microcontrollers."
            };

            // Seed Meetings for Juan Dela Cruz (s1) & others
            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-001",
                StudentId = s1.UserId,
                StudentName = s1.FullName,
                StudentEmail = s1.Email,
                StudentProgram = s1.ProgramOrTitle,
                FacultyId = f1.UserId,
                FacultyName = f1.FullName,
                FacultyEmail = f1.Email,
                Subject = "Capstone 1 Project Proposal Defense Consultation",
                Purpose = "Review manuscript Chapter 1-3 revisions and verify architecture diagram before title defense next week.",
                PreferredDate = DateTime.Today.AddDays(2),
                PreferredTime = "10:00 AM",
                MeetingType = MeetingType.FaceToFace,
                LocationOrLink = "DCSS Faculty Consultation Room (TYK 4th Floor)",
                Status = MeetingStatus.Approved,
                ScheduledDate = DateTime.Today.AddDays(2),
                ScheduledTime = "10:00 AM",
                FacultyNotes = "Approved. Please print 2 hardcopies of the revised Chapter 2 and bring your ERD diagram.",
                CreatedAt = DateTime.Now.AddDays(-3)
            });

            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-002",
                StudentId = s1.UserId,
                StudentName = s1.FullName,
                StudentEmail = s1.Email,
                StudentProgram = s1.ProgramOrTitle,
                FacultyId = f2.UserId,
                FacultyName = f2.FullName,
                FacultyEmail = f2.Email,
                Subject = "CS312 Automata Final Project Inquiry",
                Purpose = "Clarify Turing Machine simulation requirements and test case boundary limits for project submission.",
                PreferredDate = DateTime.Today.AddDays(3),
                PreferredTime = "02:00 PM",
                MeetingType = MeetingType.Online,
                LocationOrLink = "Google Meet (meet.google.com/dcss-auto-312)",
                Status = MeetingStatus.Pending,
                CreatedAt = DateTime.Now.AddHours(-18)
            });

            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-003",
                StudentId = s1.UserId,
                StudentName = s1.FullName,
                StudentEmail = s1.Email,
                StudentProgram = s1.ProgramOrTitle,
                FacultyId = f3.UserId,
                FacultyName = f3.FullName,
                FacultyEmail = f3.Email,
                Subject = "Data Science Specialization Track Consultation",
                Purpose = "Guidance on elective courses for 2nd semester and elective subject sequencing.",
                PreferredDate = DateTime.Today.AddDays(1),
                PreferredTime = "11:30 AM",
                MeetingType = MeetingType.FaceToFace,
                LocationOrLink = "DCSS Faculty Room Desk #7",
                Status = MeetingStatus.Rescheduled,
                ScheduledDate = DateTime.Today.AddDays(4),
                ScheduledTime = "01:30 PM",
                RescheduleReason = "Faculty attending Academic Council meeting on original time slot.",
                FacultyNotes = "Moved to Thursday 01:30 PM. Let me know if this works for your class schedule.",
                CreatedAt = DateTime.Now.AddDays(-2)
            });

            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-004",
                StudentId = s1.UserId,
                StudentName = s1.FullName,
                StudentEmail = s1.Email,
                StudentProgram = s1.ProgramOrTitle,
                FacultyId = f4.UserId,
                FacultyName = f4.FullName,
                FacultyEmail = f4.Email,
                Subject = "Microcontroller Hardware Prototype Troubleshooting",
                Purpose = "Need guidance testing ESP32 sensor telemetry bridge on the university campus Wi-Fi network.",
                PreferredDate = DateTime.Today.AddDays(-5),
                PreferredTime = "09:00 AM",
                MeetingType = MeetingType.FaceToFace,
                LocationOrLink = "Embedded Systems Lab (TYK 305)",
                Status = MeetingStatus.Declined,
                DeclineReason = "Outside designated consultation schedule. Please rebook during Wednesday lab hours.",
                CreatedAt = DateTime.Now.AddDays(-6)
            });

            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-005",
                StudentId = s2.UserId,
                StudentName = s2.FullName,
                StudentEmail = s2.Email,
                StudentProgram = s2.ProgramOrTitle,
                FacultyId = f1.UserId,
                FacultyName = f1.FullName,
                FacultyEmail = f1.Email,
                Subject = "OJT Industry Internship Endorsement Form Signature",
                Purpose = "Need faculty endorsement signature for software development internship at Accenture Phils.",
                PreferredDate = DateTime.Today.AddDays(1),
                PreferredTime = "01:00 PM",
                MeetingType = MeetingType.FaceToFace,
                LocationOrLink = "DCSS Faculty Consultation Room",
                Status = MeetingStatus.Pending,
                CreatedAt = DateTime.Now.AddHours(-10)
            });

            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-006",
                StudentId = s3.UserId,
                StudentName = s3.FullName,
                StudentEmail = s3.Email,
                StudentProgram = s3.ProgramOrTitle,
                FacultyId = f1.UserId,
                FacultyName = f1.FullName,
                FacultyEmail = f1.Email,
                Subject = "Midterm Grade Consultation in Web Development",
                Purpose = "Review Laboratory Exercise 4 and 5 grading criteria and discussion on missed submission.",
                PreferredDate = DateTime.Today,
                PreferredTime = "03:00 PM",
                MeetingType = MeetingType.FaceToFace,
                LocationOrLink = "DCSS Faculty Consultation Room",
                Status = MeetingStatus.Approved,
                ScheduledDate = DateTime.Today,
                ScheduledTime = "03:00 PM",
                FacultyNotes = "Please prepare your GitHub repository commit log and documentation.",
                CreatedAt = DateTime.Now.AddDays(-1)
            });

            _meetings.Add(new MeetingRequest {
                RequestId = "REQ-2026-007",
                StudentId = s4.UserId,
                StudentName = s4.FullName,
                StudentEmail = s4.Email,
                StudentProgram = s4.ProgramOrTitle,
                FacultyId = f1.UserId,
                FacultyName = f1.FullName,
                FacultyEmail = f1.Email,
                Subject = "Final Capstone Manuscript Submission & Panel Clearance",
                Purpose = "Securing adviser sign-off for final hardbound manuscript submission to library.",
                PreferredDate = DateTime.Today.AddDays(-10),
                PreferredTime = "10:30 AM",
                MeetingType = MeetingType.FaceToFace,
                LocationOrLink = "DCSS Faculty Consultation Room",
                Status = MeetingStatus.Completed,
                ScheduledDate = DateTime.Today.AddDays(-10),
                ScheduledTime = "10:30 AM",
                FacultyNotes = "Manuscript signed and approved for university archive.",
                CreatedAt = DateTime.Now.AddDays(-12)
            });

            // Seed Notifications
            _notifications.Add(new NotificationItem {
                UserId = s1.UserId,
                Title = "Meeting Request Approved",
                Message = "Prof. Maria Elena Santos approved your meeting for Capstone 1 Consultation on " + DateTime.Today.AddDays(2).ToString("MMM dd") + " at 10:00 AM.",
                Timestamp = DateTime.Now.AddHours(-2),
                IsRead = false,
                RelatedStatus = MeetingStatus.Approved
            });

            _notifications.Add(new NotificationItem {
                UserId = s1.UserId,
                Title = "Meeting Schedule Updated",
                Message = "Prof. Kristine Mae Reyes proposed a new schedule for Data Science Track Consultation: " + DateTime.Today.AddDays(4).ToString("MMM dd") + " at 01:30 PM.",
                Timestamp = DateTime.Now.AddHours(-14),
                IsRead = false,
                RelatedStatus = MeetingStatus.Rescheduled
            });

            _notifications.Add(new NotificationItem {
                UserId = s1.UserId,
                Title = "Meeting Request Submitted",
                Message = "Your request 'CS312 Automata Final Project Inquiry' with Dr. Arthur Ramos has been delivered and is awaiting review.",
                Timestamp = DateTime.Now.AddHours(-18),
                IsRead = true,
                RelatedStatus = MeetingStatus.Pending
            });

            _notifications.Add(new NotificationItem {
                UserId = s1.UserId,
                Title = "Meeting Request Declined",
                Message = "Your request 'Microcontroller Hardware Prototype Troubleshooting' was declined by Engr. Carlo Gutierrez (Reason: Outside designated consultation schedule).",
                Timestamp = DateTime.Now.AddDays(-6),
                IsRead = true,
                RelatedStatus = MeetingStatus.Declined
            });

            // Faculty Notifications
            _notifications.Add(new NotificationItem {
                UserId = f1.UserId,
                Title = "New Meeting Request Received",
                Message = "Samantha Louise Reyes (BSIT 3-B) requested a consultation for 'OJT Industry Internship Endorsement Form Signature'.",
                Timestamp = DateTime.Now.AddHours(-10),
                IsRead = false,
                RelatedStatus = MeetingStatus.Pending
            });

            _notifications.Add(new NotificationItem {
                UserId = f1.UserId,
                Title = "Upcoming Meeting Today",
                Message = "You have an approved meeting scheduled today at 03:00 PM with Mark Anthony Lim regarding Web Development.",
                Timestamp = DateTime.Now.AddHours(-1),
                IsRead = false,
                RelatedStatus = MeetingStatus.Approved
            });
        }

        // Authentication
        public User? Authenticate(string email, string password) {
            return _users.FirstOrDefault(u => 
                string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase) && 
                u.Password == password && 
                u.Status == AccountStatus.Active);
        }

        // Users
        public List<User> GetAllUsers() => _users.OrderBy(u => u.Role).ThenBy(u => u.FullName).ToList();

        public List<User> GetFacultyMembers() => 
            _users.Where(u => u.Role == UserRole.Faculty && u.Status == AccountStatus.Active)
                  .OrderBy(u => u.FullName)
                  .ToList();

        public User? GetUserById(string userId) => _users.FirstOrDefault(u => u.UserId == userId);

        public bool CreateUser(User user) {
            if (_users.Any(u => string.Equals(u.Email, user.Email, StringComparison.OrdinalIgnoreCase))) {
                return false; // Email already taken
            }
            if (string.IsNullOrEmpty(user.UserId)) {
                user.UserId = "USR-" + Guid.NewGuid().ToString("N")[..6].ToUpper();
            }
            user.CreatedAt = DateTime.Now;
            _users.Add(user);
            NotifyChange();
            return true;
        }

        public bool UpdateUser(User user) {
            var existing = _users.FirstOrDefault(u => u.UserId == user.UserId);
            if (existing == null) return false;

            existing.FullName = user.FullName;
            existing.Email = user.Email;
            existing.Role = user.Role;
            existing.Department = user.Department;
            existing.IdNumber = user.IdNumber;
            existing.ProgramOrTitle = user.ProgramOrTitle;
            existing.Phone = user.Phone;
            existing.Status = user.Status;
            if (!string.IsNullOrEmpty(user.Password)) {
                existing.Password = user.Password;
            }
            NotifyChange();
            return true;
        }

        public bool ToggleUserStatus(string userId) {
            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return false;
            user.Status = user.Status == AccountStatus.Active ? AccountStatus.Inactive : AccountStatus.Active;
            NotifyChange();
            return true;
        }

        public bool ResetPassword(string userId, string newPassword) {
            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return false;
            user.Password = newPassword;
            NotifyChange();
            return true;
        }

        // Meetings
        public List<MeetingRequest> GetAllMeetings() => _meetings.OrderByDescending(m => m.CreatedAt).ToList();

        public List<MeetingRequest> GetMeetingsForStudent(string studentId) => 
            _meetings.Where(m => m.StudentId == studentId).OrderByDescending(m => m.CreatedAt).ToList();

        public List<MeetingRequest> GetMeetingsForFaculty(string facultyId) => 
            _meetings.Where(m => m.FacultyId == facultyId).OrderByDescending(m => m.CreatedAt).ToList();

        public MeetingRequest? GetMeetingById(string requestId) => _meetings.FirstOrDefault(m => m.RequestId == requestId);

        public bool CreateMeetingRequest(MeetingRequest request) {
            if (string.IsNullOrEmpty(request.RequestId)) {
                int nextNum = _meetings.Count + 1;
                request.RequestId = $"REQ-2026-{nextNum:D3}";
            }
            request.CreatedAt = DateTime.Now;
            request.Status = MeetingStatus.Pending;
            _meetings.Insert(0, request);

            // Notify faculty
            AddNotification(new NotificationItem {
                UserId = request.FacultyId,
                Title = "New Meeting Request",
                Message = $"{request.StudentName} submitted a request: '{request.Subject}' for {request.PreferredDate:MMM dd, yyyy} at {request.PreferredTime}.",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Pending
            });

            // Notify student
            AddNotification(new NotificationItem {
                UserId = request.StudentId,
                Title = "Meeting Request Sent",
                Message = $"Your request '{request.Subject}' to {request.FacultyName} has been submitted.",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Pending
            });

            NotifyChange();
            return true;
        }

        public bool ApproveMeeting(string requestId, string? facultyNotes, string? locationOrLink) {
            var meeting = _meetings.FirstOrDefault(m => m.RequestId == requestId);
            if (meeting == null) return false;

            meeting.Status = MeetingStatus.Approved;
            meeting.ScheduledDate = meeting.PreferredDate;
            meeting.ScheduledTime = meeting.PreferredTime;
            if (!string.IsNullOrEmpty(facultyNotes)) meeting.FacultyNotes = facultyNotes;
            if (!string.IsNullOrEmpty(locationOrLink)) meeting.LocationOrLink = locationOrLink;

            AddNotification(new NotificationItem {
                UserId = meeting.StudentId,
                Title = "Meeting Approved!",
                Message = $"{meeting.FacultyName} approved your meeting '{meeting.Subject}' for {meeting.DisplayScheduledDate} at {meeting.DisplayScheduledTime}.",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Approved
            });

            NotifyChange();
            return true;
        }

        public bool RescheduleMeeting(string requestId, DateTime newDate, string newTime, string reason) {
            var meeting = _meetings.FirstOrDefault(m => m.RequestId == requestId);
            if (meeting == null) return false;

            meeting.Status = MeetingStatus.Rescheduled;
            meeting.ScheduledDate = newDate;
            meeting.ScheduledTime = newTime;
            meeting.RescheduleReason = reason;

            AddNotification(new NotificationItem {
                UserId = meeting.StudentId,
                Title = "Meeting Rescheduled",
                Message = $"{meeting.FacultyName} rescheduled '{meeting.Subject}' to {newDate:MMM dd, yyyy} at {newTime}. Reason: {reason}",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Rescheduled
            });

            NotifyChange();
            return true;
        }

        public bool DeclineMeeting(string requestId, string reason) {
            var meeting = _meetings.FirstOrDefault(m => m.RequestId == requestId);
            if (meeting == null) return false;

            meeting.Status = MeetingStatus.Declined;
            meeting.DeclineReason = reason;

            AddNotification(new NotificationItem {
                UserId = meeting.StudentId,
                Title = "Meeting Request Declined",
                Message = $"{meeting.FacultyName} declined '{meeting.Subject}'. Reason: {reason}",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Declined
            });

            NotifyChange();
            return true;
        }

        public bool CancelMeeting(string requestId) {
            var meeting = _meetings.FirstOrDefault(m => m.RequestId == requestId);
            if (meeting == null) return false;

            meeting.Status = MeetingStatus.Cancelled;

            AddNotification(new NotificationItem {
                UserId = meeting.FacultyId,
                Title = "Meeting Cancelled by Student",
                Message = $"{meeting.StudentName} cancelled meeting '{meeting.Subject}'.",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Cancelled
            });

            NotifyChange();
            return true;
        }

        public bool CompleteMeeting(string requestId) {
            var meeting = _meetings.FirstOrDefault(m => m.RequestId == requestId);
            if (meeting == null) return false;

            meeting.Status = MeetingStatus.Completed;

            AddNotification(new NotificationItem {
                UserId = meeting.StudentId,
                Title = "Meeting Completed",
                Message = $"Your consultation '{meeting.Subject}' with {meeting.FacultyName} has been marked as completed.",
                Timestamp = DateTime.Now,
                IsRead = false,
                RelatedStatus = MeetingStatus.Completed
            });

            NotifyChange();
            return true;
        }

        // Notifications
        public List<NotificationItem> GetNotificationsForUser(string userId) => 
            _notifications.Where(n => n.UserId == userId).OrderByDescending(n => n.Timestamp).ToList();

        public int GetUnreadNotificationCount(string userId) => 
            _notifications.Count(n => n.UserId == userId && !n.IsRead);

        public void MarkNotificationAsRead(string notificationId) {
            var item = _notifications.FirstOrDefault(n => n.NotificationId == notificationId);
            if (item != null) {
                item.IsRead = true;
                NotifyChange();
            }
        }

        public void MarkAllNotificationsAsRead(string userId) {
            var items = _notifications.Where(n => n.UserId == userId && !n.IsRead).ToList();
            foreach (var item in items) {
                item.IsRead = true;
            }
            if (items.Any()) {
                NotifyChange();
            }
        }

        public void AddNotification(NotificationItem notification) {
            _notifications.Insert(0, notification);
            NotifyChange();
        }

        // Availability
        public FacultyAvailability GetFacultyAvailability(string facultyId) {
            if (!_availabilities.TryGetValue(facultyId, out var avail)) {
                avail = new FacultyAvailability { FacultyId = facultyId };
                _availabilities[facultyId] = avail;
            }
            return avail;
        }

        public void SaveFacultyAvailability(FacultyAvailability availability) {
            _availabilities[availability.FacultyId] = availability;
            NotifyChange();
        }

        // Stats
        public (int pending, int approved, int rescheduled, int declined) GetStudentStats(string studentId) {
            var list = _meetings.Where(m => m.StudentId == studentId).ToList();
            return (
                list.Count(m => m.Status == MeetingStatus.Pending),
                list.Count(m => m.Status == MeetingStatus.Approved),
                list.Count(m => m.Status == MeetingStatus.Rescheduled),
                list.Count(m => m.Status == MeetingStatus.Declined)
            );
        }

        public (int total, int pending, int approved, int declined, int completed) GetFacultyStats(string facultyId) {
            var list = _meetings.Where(m => m.FacultyId == facultyId).ToList();
            return (
                list.Count,
                list.Count(m => m.Status == MeetingStatus.Pending),
                list.Count(m => m.Status == MeetingStatus.Approved),
                list.Count(m => m.Status == MeetingStatus.Declined),
                list.Count(m => m.Status == MeetingStatus.Completed)
            );
        }

        public (int totalUsers, int totalStudents, int totalFaculty, int totalMeetings) GetAdminStats() {
            return (
                _users.Count,
                _users.Count(u => u.Role == UserRole.Student),
                _users.Count(u => u.Role == UserRole.Faculty),
                _meetings.Count
            );
        }
    }
}
