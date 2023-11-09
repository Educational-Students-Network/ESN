import NavBar from "../nav-bar/NavBar";
import { Event } from "../../app/models/event";
import EventList from "./EventList";

const events: Event[] = [
  {
    id: 1,
    speakers: "Speaker 1, Speaker 2",
    description: "Description for Event 1",
    time: "10:00 AM - 12:00 PM",
    authorUsername: "user1",
    place: "Conference Room A",
    pictureUrl: "https://example.com/event1.jpg",
  },
  {
    id: 2,
    speakers: "Speaker 3, Speaker 4",
    description: "Description for Event 2",
    time: "1:00 PM - 3:00 PM",
    authorUsername: "user2",
    place: "Conference Room B",
    pictureUrl: "https://example.com/event2.jpg",
  },
  {
    id: 3,
    speakers: "Speaker 5",
    description: "Description for Event 3",
    time: "3:30 PM - 5:30 PM",
    authorUsername: "user3",
    place: "Conference Room C",
    pictureUrl: "https://example.com/event3.jpg",
  },
  // Add more events as needed
];

export default function Events() {
  return (
    <>
      <div className="page-class">
        <NavBar />
        <div className="event-list">
          <EventList events={events} />
        </div>
      </div>
    </>
  );
}
