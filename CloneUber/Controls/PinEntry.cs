using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace CloneUber.Controls
{
    public class PinEntry : StackLayout, INotifyPropertyChanged
    {
        private ObservableCollection<Entry> pinEntries = new ObservableCollection<Entry>();
        private string pin;
        private int length;

        public PinEntry()
        {
            Orientation = StackOrientation.Horizontal;
        }

        // Propiedad para obtener y establecer el PIN ingresado
        public string PIN
        {
            get { return pin; }
            set
            {
                if (pin != value)
                {
                    pin = value;
                    OnPropertyChanged(nameof(PIN));
                }
            }
        }

        // Propiedad para obtener y establecer la longitud del control
        public int Length
        {
            get { return length; }
            set
            {
                if (length != value)
                {
                    length = value;
                    CreatePinEntries(); // Vuelve a crear los Entry si cambia la longitud
                    OnPropertyChanged(nameof(Length));
                }
            }
        }

        // Método para crear los Entry basados en la longitud especificada
        private void CreatePinEntries()
        {
            pinEntries.Clear(); // Limpiar la colección actual

            // Crear los Entry para cada dígito del PIN
            for (int i = 0; i < Length; i++)
            {
                var entry = new Entry
                {
                    Keyboard = Keyboard.Numeric,
                    MaxLength = 1,
                    WidthRequest = 40, // Ancho personalizado para cada Entry
                    Margin = new Thickness(5) // Margen personalizado para separación visual
                };

                // Suscribirse al evento de texto cambiado para la navegación entre los Entry
                entry.TextChanged += (sender, args) =>
                {
                    var currentEntry = (Entry)sender;
                    if (!string.IsNullOrEmpty(currentEntry.Text) && currentEntry.Text.Length == 1)
                    {
                        var index = pinEntries.IndexOf(currentEntry);
                        if (index < pinEntries.Count - 1)
                        {
                            pinEntries[index + 1].Focus();
                        }
                    }
                    UpdatePin(); // Actualizar el valor del PIN cuando cambia el texto
                };

                pinEntries.Add(entry);
                Children.Add(entry);
            }
        }

        // Método para actualizar el valor del PIN
        private void UpdatePin()
        {
            string newPin = "";
            foreach (var entry in pinEntries)
            {
                newPin += entry.Text;
            }
            PIN = newPin;
        }

        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

