import { NavLink } from "react-router-dom";
import { useAppSelector } from "../../app/store/configureStore";
import "../../styles/style.css";

export default function NavBar() {
  const {user} = useAppSelector(state => state.account);

 
 
  return (
    <div className="NavBar">
      <div className="logo">
        <NavLink to={"/"}>
          <h1>ESN</h1>
        </NavLink>
      </div>

      <div className="routes el">
        <NavLink to={"/"}>
          <h1>Home</h1>
        </NavLink>
        <NavLink to={"/events"}>
          <h1>Events</h1>
        </NavLink>
        <NavLink to={"/createEvent"}>
          <h1>Create Event</h1>
        </NavLink>
        <NavLink to={"/aboutUs"}>
          <h1>About Us</h1>
        </NavLink>
        
      </div>
      {user ? 
        <div> їбало</div> 
       : 
        <div className="login-reg-lang el">
        <div>
          <NavLink to={"/login"}>
            <button>Login</button>
          </NavLink>
          <NavLink to={"/register"}>
            <button>Register</button>
          </NavLink>
        </div>
      </div>
      }
    </div>
  );
}
