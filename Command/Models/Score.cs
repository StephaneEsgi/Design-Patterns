using System;
using SQLite;

namespace Command {
    public class Score
    {
        public static ScoreBuilder Builder(){
            return new ScoreBuilder();
        }

        [PrimaryKey]
        public int Id { get; set; }

        public float Value { get; set; }

        public DateTime Date { get; set; }

        public Score() { }

        public override string ToString() => $"Score[{Id}, {Value}, {Date}]";

        #region Builder
        public class ScoreBuilder{
            Score score;

            public ScoreBuilder()
            {
                score = new Score();
            }

            public ScoreBuilder Id (int id){
                score.Id = id;
                return this;
            }
            public ScoreBuilder Value (float value){
                score.Value = value;
                return this;
            }
            public ScoreBuilder Date (DateTime date){
                score.Date = date;
                return this;
            }

            public Score Build(){
                return score;
            }

        }
        #endregion

    }
}