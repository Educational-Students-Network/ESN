import "../../styles/style.css";
import redElips from "../../img/svg/red-elips.svg";
import blueElips from "../../img/svg/blue-elips.svg";
import greenElips from "../../img/svg/green-elips.svg";
import line from "../../img/svg/line_home.svg";
import home_info_1 from "../../img/svg/home-info-1.svg";
import home_info_2 from "../../img/svg/home-info-2.svg";
import home_info_3 from "../../img/svg/home-info-3.svg";
import NavBar from "../nav-bar/NavBar";

export default function HomePage() {
  return (
    <>
      <div className="page-class">
        <NavBar />
        <section className="home gang">
          <div className="group">
            <div>
              <img src={redElips} alt="red-elips" />{" "}
              <h1>&nbsp;&nbsp; Educational</h1>
            </div>
            <div>
              <img src={blueElips} alt="blue-elips" />{" "}
              <h1>&nbsp;&nbsp; Social</h1>
            </div>
            <div>
              <img src={greenElips} alt="green-elips" />{" "}
              <h1>&nbsp;&nbsp; Network</h1>
            </div>
          </div>
        </section>
        <section className="home graph">
          <img src={line} className="line" />
          <div className="container">
            <div className="item">Explore</div>
            <div className="item">Contend</div>
            <div className="item">Inspire</div>
            <div className="item">Organize</div>
          </div>
        </section>
        <section className="home info">
          <div className="group">
            <div className="row">
              <img src={home_info_1} alt="home_info_1" />
              <div>
                <h2>Different activities</h2>
                <p>
                Discover a variety of activities for active recreation and education.
                </p>
              </div>
            </div>

            <div className="row">
              <div>
                <h2>Interactive community</h2>
                <p>
                Join our interactive community where you can communicate, collaborate and grow together with different people from all over the world.
                </p>
              </div>
              <img src={home_info_2} alt="home_info_2" />
            </div>

            <div className="row">
              <img src={home_info_3} alt="home_info_3" />
              <div>
                <h2>Job offers</h2>
                <p>
                Find your ideal job on our website. We offer a wide range of jobs in various fields.
                </p>
              </div>
            </div>
          </div>
        </section>
      </div>
    </>
  );
}
