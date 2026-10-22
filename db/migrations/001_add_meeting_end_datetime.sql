USE dcss_db;

ALTER TABLE appointments
ADD COLUMN meeting_end_datetime DATETIME NULL AFTER meeting_datetime;
