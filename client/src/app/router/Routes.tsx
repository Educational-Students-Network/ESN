import { createBrowserRouter, Navigate } from "react-router-dom";
import AboutPage from "../../features/about/AboutPage";
import Login from "../../features/account/Login";
import Register from "../../features/account/Register";
import Inventory from "../../features/admin/Inventory";
import BasketPage from "../../features/basket/BasketPage";
import Catalog from "../../features/catalog/Catalog";
import ProductDetails from "../../features/catalog/ProductDetails";
import CheckoutWrapper from "../../features/checkout/CheckoutWrapper";
import ContactPage from "../../features/contact/ContactPage";
import Orders from "../../features/orders/Orders";
import NotFound from "../errors/NotFound";
import ServerError from "../errors/ServerError";
import App from "../layout/App";
import RequireAuth from "./RequireAuth";
import HomePage from "../../features/home/HomePage";
import PasswordRecovery from "../../features/account/PasswordRecovery";
import EmailConfimation from "../../features/account/EmailConfirmation";
import Profile from "../../features/account/Profile";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            // authenticated routes
            {element: <RequireAuth />, children: [
                {path: 'checkout', element: <CheckoutWrapper />},
                {path: 'orders', element: <Orders />},
            ]},
            // admin routes
            {element: <RequireAuth roles={['Admin']} />, children: [
                {path: 'inventory', element: <Inventory />},
            ]},
            {path:'', element: <HomePage />},
            {path: 'catalog', element: <Catalog />},
            {path: 'catalog/:id', element: <ProductDetails />},
            {path: 'about', element: <AboutPage />},
            {path: 'contact', element: <ContactPage />},
            {path: 'server-error', element: <ServerError />},
            {path: 'not-found', element: <NotFound />},
            {path: 'basket', element: <BasketPage />},
            {path: 'login', element: <Login />},
            {path: 'register', element: <Register />},
            {path:'passwordRecovery', element: <PasswordRecovery />},
            {path: 'emailConfirmation', element: <EmailConfimation />},
            {path: 'profile', element: <Profile />},
            {path: '*', element: <Navigate replace to='/not-found' />}
        ]
    }
])