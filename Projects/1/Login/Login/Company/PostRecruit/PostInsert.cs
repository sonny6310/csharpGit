using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Company.PostRecruit
{
      class PostInsert
      {
            private string textSubject;
            private string textField;
            private string textPay;
            private DateTime dateTimeStart;
            private DateTime dateTimeFinish;
            private string textPlace;
            private DateTime deadLineTime;
            private string textContent;
            
            public string text_Subject { get { return textSubject; }set { textSubject = value; }}
            public string text_Field { get {return textField; } set {textField=value; } }
            public string text_Pay { get {return textPay; } set {textPay=value; } }
            public string text_Place { get {return textPlace; }set {textPlace=value; } }
            public DateTime date_TimeStart { get {return dateTimeStart; }set {dateTimeStart=value; } }
            public DateTime date_TimeFinish { get {return dateTimeFinish; } set {dateTimeFinish=value; } }
            public DateTime dead_LineTime { get {return deadLineTime; }  set {deadLineTime=value; } }
            public string text_Content { get {return textContent; } set {textContent=value; } }
    
      }
}
