DECLARE @pFirstName nvarchar(30);
DECLARE @pLastName nvarchar(30);
DECLARE @pMeetingID nvarchar(30);
DECLARE @pOccured bit;
DECLARE @pDate datetime;
DECLARE @pCity nvarchar;
DECLARE @pAddress nvarchar;

Declare @testDate datetime;

SET @pFirstName = 'yoad';
SET @pLastName = '';
SET @pMeetingID = '';
SET @pOccured = 'true';
SET @pCity = '';
SET @pAddress = '';
--SET @pDate = '2017-05-21T00:00:00';


SET @testDate = ISNULL(@pDate, GETDATE());

SELECT mitmoded.firstName,mitmoded.lastName, meeting.* FROM MeetingsTB meeting, MitmodedTb mitmoded WHERE meeting.mitmodedID = mitmoded.ID 
AND (mitmoded.firstName LIKE '%' + @pFirstName + '%' AND mitmoded.lastName LIKE '%' + @pLastName + '%')
AND meeting.meetingID LIKE '%' + @pMeetingID + '%'
AND meeting.occured = @pOccured
AND meeting.date = @testDate
AND meeting.city LIKE '%' + @pCity + '%'
AND meeting.address LIKE '%' + @pAddress + '%';