<<<<<<< HEAD
import { useState } from "react";
=======
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
import { Event } from "../../app/models/event";
import "../../styles/style.css";
interface Props {
  event: Event;
}

export default function EventCard({ event }: Props) {
<<<<<<< HEAD
  const [registered, setRegistered] = useState(false) 
  // we need to pass data here

  return (
    <div className="event">
      <div className="header flexSpaceBetween">
        <div className="header__left flexCenter">
          <img alt="logo" />
          <div className="header__left__group">
            <p>{event.authorUsername}</p>
            <p>status</p>
          </div>
        </div>
        <div className="header__right">
          <img alt="menu" />
        </div>
      </div>
      <img className="event__banner" src={event.pictureUrl} alt="banner" />
      <div className="event__description flexSpaceBetween">
        <div className="event__description__left">
          <div className="event__description__date">
=======
  return (
    <div className="event">
      <div className="header">
        <p>Logo</p>
        <p>{event.authorUsername}</p>
      </div>
      <img src={event.pictureUrl} alt="banner" />
      <div className="description">
        <div className="time-place-speakers">
          <div className="date-place">
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
            <p>Дата та час: {event.time}</p>
            <p>Місце проведення: {event.place}</p>
          </div>

          <div className="speakers">
            <p>Головні спікери</p>
            <ul>
              {event.speakers.split(", ").map((item, index) => (
                <li key={index}>{item}</li>
              ))}
            </ul>
          </div>
        </div>
<<<<<<< HEAD
        <div className="event__description__right">
=======
        <div className="event-description">
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
          <p>Опис події:</p>
          <p>{event.description}</p>
        </div>
      </div>
<<<<<<< HEAD
      <div className="event__line"></div>
      <div className="event__reactions flexSpaceBetween">
        <div className="reactions__block flexCenter">
          <img alt="like-img" />
          <p>Like</p>
        </div>
        <div className="reactions__block flexCenter">
          <img alt="reg-img" />
          <p>{registered ? "Registered" : "Register"}</p>
        </div>
=======
      <div className="reactions">
        <p>Like</p>
        <p>Comment</p>
        <p>Repost</p>
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
      </div>
    </div>
  );
}
