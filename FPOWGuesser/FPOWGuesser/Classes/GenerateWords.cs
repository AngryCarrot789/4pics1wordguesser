using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FPOWGuesser
{
    public class GenerateWords : INotifyPropertyChanged
    {
        private ObservableCollection<string> posword;
        public ObservableCollection<string> PossibleWordsList { get { return posword; } set { posword = value; RaisePropertyChanged(nameof(PossibleWordsList)); } }
        private int rawWords;
        public int RawWords { get { return rawWords; } set { rawWords = value; RaisePropertyChanged(nameof(RawWords)); } }
        private int realWords;
        public int RealWords { get { return realWords; } set { realWords = value; RaisePropertyChanged(nameof(RealWords)); } }
        private bool allowDictionary = false;
        public bool AllowDictionary { get { return allowDictionary; } set { allowDictionary = value; RaisePropertyChanged(nameof(AllowDictionary)); } }
        private string letters;
        public string Letters { get { return letters; } set { letters = value; RaisePropertyChanged(nameof(Letters)); } }
        private string search;
        public string Search { get { return search; } set { search = value; RaisePropertyChanged(nameof(Search)); } }
        private string searchList;
        public string SearchList { get { return searchList; } set { searchList = value; RaisePropertyChanged(nameof(SearchList)); } }
        private int letterNumbers;
        public int LettersNumbers { get { return letterNumbers; } set { letterNumbers = value; RaisePropertyChanged(nameof(LettersNumbers)); } }
        public ICommand BeginGenerating { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ClearList { get; set; }
        public ICommand OpenHelpWinThing { get; set; }
        public ICommand DeleteSelected { get; set; }
        public char HelpWin { get { return helpWin; } set { helpWin = value; RaisePropertyChanged(nameof(HelpWin)); } }
        private char helpWin;
        public int HelpWint { get { return helpWint; } set { helpWint = value; RaisePropertyChanged(nameof(HelpWint)); } }
        private int helpWint;
        public GenerateWords()
        {
            PossibleWordsList = new ObservableCollection<string>();
            BeginGenerating = new RelayCommand(GetEm);
            SearchCommand = new RelayCommand(SearchCMD);
            ClearList = new RelayCommand(clearList);
            OpenHelpWinThing = new RelayCommand(oeoeo);
            DeleteSelected = new RelayCommand(DSelected);
            LettersNumbers = 3;
        }
        private void DSelected(object sus) { PossibleWordsList.Remove(SearchList); }
        private void oeoeo(object nule) { new Helpwintthingy(PossibleWordsList, HelpWin, HelpWint).Show(); }
        private void GetEm(object nuu) { Get(Letters, LettersNumbers); }
        private void SearchCMD(object snu) { if (PossibleWordsList.Contains(Search)) { SearchList = Search; } }
        private void clearList(object suoo)
        {
            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
            {
                PossibleWordsList.Clear();
                RawWords = 0;
                RealWords = 0;
            });
        }

        public void Get(string Letters, int words)
        {
            Task.Factory.StartNew(() =>
            {
                RawWords = 0;
                List<string> values = new List<string>();
                foreach (char oooti in Letters) { values.Add(oooti.ToString()); }
                // Add onto the combinations.
                int qq = 0;
                for (int i = 1; i < words; i++)
                {
                    // Make combinations containing i + 1 letters.
                    List<string> new_values = new List<string>();
                    int g = 0;
                    foreach (string str in values)
                    {
                        // Add all possible letters to this string.
                        foreach (char oooti in Letters) { new_values.Add(str + oooti); g++; RawWords = g; }
                    }

                    // Replace the old values with the new ones.
                    values = new_values;
                }
                HashSet<string> Dict = GetEngDictionary();
                foreach (string siis in values)
                {
                    //Match dictionary for non-duped words
                    if (AllowDictionary)
                    {
                        var matches = new List<string>();
                        //checks for non-duped words
                        if (!PossibleWordsList.Contains(siis))
                        {
                            //match word with dictionary

                            if (Dict.Contains(siis))
                            {
                                App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
                                {
                                    PossibleWordsList.Add(siis); qq++;
                                    RealWords = qq;
                                });
                            }
                        }
                        foreach (string gh in matches)
                        {
                            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
                            {
                                PossibleWordsList.Add(gh);
                            });
                        }
                    }

                    //list every non-duplicate word generated.
                    else
                    {
                        if (!PossibleWordsList.Contains(siis))
                        {
                            App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
                            {
                                PossibleWordsList.Add(siis);
                            });
                        }
                    }
                }
                RealWords = qq;
            });
        }

        public void HelpThing(List<string> list)
        {
            HashSet<string> hs = new HashSet<string>();
            foreach (string gg in list)
            {
                hs.Add(gg);
                if (gg[5] == 'e') { }
            }
        }

        public HashSet<string> GetEngDictionary()
        {
           HashSet<string> dd = new HashSet<string>();
            foreach (string g in File.ReadAllLines(@"F:\VS Files\FPOWGuesser\FPOWGuesser\words.txt"))
            {
               dd.Add(g.ToLower());
            }
            return dd;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
