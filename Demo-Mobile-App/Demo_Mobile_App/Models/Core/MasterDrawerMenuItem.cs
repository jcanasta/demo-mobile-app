using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Mobile_App.Models.Core
{

    public class MasterDrawerMenuItem : ModelBase
    {
        int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }
        Type _targetType;
        public Type TargetType
        {
            get { return _targetType; }
            set
            {
                _targetType = value;
                OnPropertyChanged();
            }
        }
    }
}