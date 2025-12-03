using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMauiMobileApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.Model.Messages
{
    public class UpdateMovieMessages : ValueChangedMessage<(MarvelMovies OldValue, MarvelMovies NewValue)>
    {

        public UpdateMovieMessages(MarvelMovies oldValue, MarvelMovies newValue) : base((oldValue, newValue)) { }

        public MarvelMovies OldValue => Value.OldValue;
        public MarvelMovies NewValue => Value.NewValue;


    }
}
