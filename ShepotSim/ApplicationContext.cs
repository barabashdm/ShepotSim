using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ShepotSim
{
    class ApplicationContext : DbContext
    {
        public DbSet<CheckPoint> CheckPoints
        {
            get;
            set;
        }

        public DbSet<Measurement> Measurements
        {
            get;
            set;
        }

        public DbSet<NormalizedSoundLevel> NormalizedSoundLevels
        {
            get;
            set;
        }

        public DbSet<IntelligibilityNorm> IntelligibilityNorms
        {
            get;
            set;
        }

        public DbSet<SproofingNorm> SproofingNorms
        {
            get;
            set;
        }

        public DbSet<GenerationFirstCheckPoint> GenerationFirstCheckPoints
        {
            get;
            set;
        }

        public DbSet<GenerationFirstMeasurement> GenerationFirstMeasurements
        {
            get;
            set;
        }

        public DbSet<VerificationValue> VerificationValues
        {
            get;
            set;
        }

        public DbSet<User> Users
        {
            get;
            set;
        }

        public DbSet<SignalNoiseNormValue> SignalNoiseNormValues
        {
            get;
            set;
        }

        public ApplicationContext()
            : base("myConnection")
        {
        }
    }
}
