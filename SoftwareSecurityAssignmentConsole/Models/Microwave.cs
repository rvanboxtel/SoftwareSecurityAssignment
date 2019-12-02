using System.ComponentModel;

namespace Models
{
    /// <inheritdoc />
    /// <summary>
    ///     The model for all the current input of the microwave.
    /// </summary>
    public class MicrowaveData : INotifyPropertyChanged
    {
        #region Attributes
        
        /// <summary>
        ///     The time.
        /// </summary>
        private int _time;
        
        /// <summary>
        ///     The is open clicked.
        /// </summary>
        private bool _isOpen;

        /// <summary>
        ///     The is start clicked.
        /// </summary>
        private bool _isStartClicked;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the time.
        /// </summary>
        public int Time
        {
            get => _time;

            set
            {
                if (_time == value) return;

                _time = value;

                // Send the event for this property
                RaisePropertyChanged("Time");

                // Send events for properties that depend on this property
                RaisePropertyChanged("TimeWithMinutes");
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the door is opened.
        /// </summary>
        public bool IsOpen
        {
            get => _isOpen;
            set
            {
                if (_isOpen == value) return;

                _isOpen = value;

                // Send the event for this property
                RaisePropertyChanged("IsOpenClicked");

                // Send events for properties that depend on this property
                RaisePropertyChanged("OpenButtonText");
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the start is clicked.
        /// </summary>
        public bool IsStartClicked
        {
            get => _isStartClicked;
            set
            {
                if (_isStartClicked == value) return;

                _isStartClicked = value;

                // Send the event for this property
                RaisePropertyChanged("IsStartClicked");

                // Send events for properties that depend on this property
            }
        }

        #endregion

        #region Events

        /// <summary>
        ///     the event that is send when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region EventSenders

        /// <summary>
        ///     send the <see cref="PropertyChanged" /> event.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        protected virtual void RaisePropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}