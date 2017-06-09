SELECT mitmoded.firstName,mitmoded.lastName, meeting.* FROM MeetingsTB meeting, MitmodedTb mitmoded WHERE meeting.mitmodedID = mitmoded.ID 
AND meeting.coordinatorID = 302184379;