﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Common
{
    public class Messages
    {
        //museum
        public const string MUSEUM_GET_ALL_ERROR = "Error occured while getting all museums, please try again.";
        public const string MUSEUM_GET_ID_ERROR = "Error occured while getting museum with id: ";
        public const string MUSEUM_DELETE_ERROR = "Cannot delete museum: ";
        public const string MUSEUM_NOT_FOUND_ERROR = "Museum not found: ";

        //auditorium
        public const string AUDITORIUM_GET_ID_ERROR = "Error occured while getting auditorium with id: ";
        public const string AUDITORIUM_GET_ALL_ERROR = "Error occured while getting all auditoriums, please try again.";
        public const string AUDITORIUM_DELETE_ERROR = "Cannot delete autitorium: ";
        public const string AUDITORIUM_NOT_FOUND_ERROR = "Auditorium not found: ";

        //ticket
        public const string TICKET_GET_ALL_ERROR = "Error occured while getting all tickets, please try again.";
        public const string TICKET_GET_ID_ERROR = "Error occured while getting ticket with id: ";

        //user
        public const string USERS_GET_ALL_ERROR = "Error occured while getting all users, please try again.";
        public const string USERS_GET_ID_ERROR = "Error occured while getting user with id: ";

        //exhibition
        public const string EXHIBITIONS_GET_ALL_ERROR = "Error occured while getting all exhibitions, please try again.";
        public const string EXHIBITION_GET_ID_ERROR = "Error occured while getting exhibition with id: ";
        public const string EXHIBITIONS_LIST_IS_EMPTY = "List of exhibitions are empty and you can't delete.";
        public const string EXHIBITION_DOES_NOT_EXIST = "Does not exist exhibition with this id. ";
        public const string EXHIBITION_IN_THE_FUTURE = "Can not delete. Exhibition will be in the future! Try again later...";
        public const string EXHIBITION_IS_NOT_OVER = "The exhibition is not over yet";
        public const string A_TICKET_TO_THIS_EXHIBITION_WAS_PURCHASED = "A ticket to this exhibition was purchased";

        //exhibit
        public const string EXHIBITS_GET_ALL_ERROR = "Error occured while getting all exhibits, please try again.";
        public const string EXHIBIT_GET_ID_ERROR = "Error occured while getting exhibit with id: ";
        public const string EXHIBITS_EMPTY_LIST = "List of exhibits are empty and you can't delete.";
        public const string EXHIBIT_DOES_NOT_EXIST = "Does not exist exhibit with this id. ";


        //tag
        public const string TAG_GET_ID_ERROR = "Error occured while getting tag with id: ";
        public const string TAGS_GET_ALL_ERROR = "Error occured while getting all tags, please try again.";




    }
}
