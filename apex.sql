--
-- PostgreSQL database dump
--

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: chec; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE public.chec (
    id_chec integer NOT NULL,
    chec timestamp without time zone NOT NULL,
    staff_id_staff integer NOT NULL
);


ALTER TABLE public.chec OWNER TO postgres;

--
-- Name: migrations; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE public.migrations (
    id_mig integer NOT NULL,
    date_hiring date NOT NULL,
    date_dismissal date,
    staff_id_staff integer NOT NULL
);


ALTER TABLE public.migrations OWNER TO postgres;

--
-- Name: notes; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE public.notes (
    id_notes integer NOT NULL,
    date_notes timestamp without time zone NOT NULL,
    text_notes text NOT NULL,
    users_id_user integer NOT NULL
);


ALTER TABLE public.notes OWNER TO postgres;

--
-- Name: schedule; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE public.schedule (
    id_sch integer NOT NULL,
    date_work date NOT NULL,
    opening_hours character varying(13) NOT NULL,
    staff_id_staff integer NOT NULL
);


ALTER TABLE public.schedule OWNER TO postgres;

--
-- Name: staff; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE public.staff (
    id_staff integer NOT NULL,
    first_name character varying(50) NOT NULL,
    last_name character varying(50) NOT NULL,
    patronymic character varying(50) NOT NULL,
    post character varying(50) NOT NULL,
    home_address character varying(100) NOT NULL,
    phone_number character varying(11) NOT NULL,
    birthday date
);


ALTER TABLE public.staff OWNER TO postgres;

--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE public.users (
    id_user integer NOT NULL,
    login character varying(100) NOT NULL,
    password character varying(100) NOT NULL,
    staff_id_staff integer NOT NULL,
    admin boolean
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Data for Name: chec; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.chec (id_chec, chec, staff_id_staff) FROM stdin;
\.


--
-- Data for Name: migrations; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.migrations (id_mig, date_hiring, date_dismissal, staff_id_staff) FROM stdin;
1	2012-03-12	9999-12-31	1
2	2017-07-25	9999-12-31	2
3	2020-12-12	9999-12-31	3
\.


--
-- Data for Name: notes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.notes (id_notes, date_notes, text_notes, users_id_user) FROM stdin;
\.


--
-- Data for Name: schedule; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.schedule (id_sch, date_work, opening_hours, staff_id_staff) FROM stdin;
\.


--
-- Data for Name: staff; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.staff (id_staff, first_name, last_name, patronymic, post, home_address, phone_number, birthday) FROM stdin;
1	Ирина	Рубина	Александровна	posttest	adres	88005553555	2022-05-29
2	Евгений	дягтёв	Игоревич	posttest	adres	88005553555	2022-05-29
3	f	f	f	Товаровед	f	88888888888	2020-12-12
\.


--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id_user, login, password, staff_id_staff, admin) FROM stdin;
1	admin	admin	1	t
2	evg	evg	2	f
\.


--
-- Name: check_pk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY public.chec
    ADD CONSTRAINT check_pk PRIMARY KEY (id_chec);


--
-- Name: migrations_pk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY public.migrations
    ADD CONSTRAINT migrations_pk PRIMARY KEY (id_mig);


--
-- Name: notes_pk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY public.notes
    ADD CONSTRAINT notes_pk PRIMARY KEY (id_notes);


--
-- Name: schedule_pk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY public.schedule
    ADD CONSTRAINT schedule_pk PRIMARY KEY (id_sch);


--
-- Name: staff_pk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pk PRIMARY KEY (id_staff);


--
-- Name: users_pk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pk PRIMARY KEY (id_user);


--
-- Name: users__idx; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE UNIQUE INDEX users__idx ON public.users USING btree (staff_id_staff);


--
-- Name: check_staff_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.chec
    ADD CONSTRAINT check_staff_fk FOREIGN KEY (staff_id_staff) REFERENCES public.staff(id_staff);


--
-- Name: migrations_staff_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.migrations
    ADD CONSTRAINT migrations_staff_fk FOREIGN KEY (staff_id_staff) REFERENCES public.staff(id_staff);


--
-- Name: notes_users_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notes
    ADD CONSTRAINT notes_users_fk FOREIGN KEY (users_id_user) REFERENCES public.users(id_user);


--
-- Name: schedule_staff_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.schedule
    ADD CONSTRAINT schedule_staff_fk FOREIGN KEY (staff_id_staff) REFERENCES public.staff(id_staff);


--
-- Name: users_staff_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_staff_fk FOREIGN KEY (staff_id_staff) REFERENCES public.staff(id_staff);


--
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


--
-- PostgreSQL database dump complete
--

