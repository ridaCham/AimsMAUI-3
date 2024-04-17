using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class GeneticTestManager : IGenetic_TestService
        {
            IGenetic_TestDal _genetic_TestDal;
            public GeneticTestManager(IGenetic_TestDal genetic_TestDal)
            {
                _genetic_TestDal = genetic_TestDal;
            }
            public IResult Add(Genetic_Test genetic_Test)
            {
                _genetic_TestDal.Add(genetic_Test);
                return new SuccessResult();
            }

            public IResult Delete(Genetic_Test genetic_Test)
            {
                _genetic_TestDal.Delete(genetic_Test);
                return new SuccessResult();
            }

            public IDataResult<Genetic_Test> Get(int id)
            {
                return new SuccessDataResult<Genetic_Test>(_genetic_TestDal.
                                Get(p => p.Id == id));
            }

            public IDataResult<List<Genetic_Test>> GetAll()
            {
                return new SuccessDataResult<List<Genetic_Test>>(_genetic_TestDal.GetAll());
            }

            public IDataResult<List<Genetic_Test>> GetAllByPatientId(string patientId)
            {
                return new SuccessDataResult<List<Genetic_Test>>(_genetic_TestDal.GetAll(p => p.PatientCode == patientId));
            }

            public IDataResult<Genetic_Test> GetByPatientId(string patientId)
            {
                return new SuccessDataResult<Genetic_Test>(_genetic_TestDal.
                    Get(p => p.PatientCode == patientId));
            }

            public IResult Update(Genetic_Test genetic_Test)
            {
                _genetic_TestDal.Update(genetic_Test);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {
                this._genetic_TestDal.importRecords(dataFile, tableName);
                return new SuccessResult();
            }
        }
    }


