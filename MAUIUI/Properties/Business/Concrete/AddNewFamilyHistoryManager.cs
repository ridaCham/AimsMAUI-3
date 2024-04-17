using MAUIUI.Business.Abstract;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;
using MAUIUI.Entities.Concrete;

namespace MAUIUI.Business.Concrete
{
    public class AddNewFamilyHistoryManager : IAddNewFamilyHistoryService
        {
            IAddNewFamilyHistoryDal addNewFamilyHistoryDal;

            public AddNewFamilyHistoryManager(IAddNewFamilyHistoryDal addNewFamilyHistoryDal)
            {
                this.addNewFamilyHistoryDal = addNewFamilyHistoryDal;
            }


            public IResult Add(AddNewFamilyHistory addNewFamilyHistory)
            {
                addNewFamilyHistoryDal.Add(addNewFamilyHistory);
                return new SuccessResult();
            }

            public IResult Delete(AddNewFamilyHistory addNewFamilyHistory)
            {
                addNewFamilyHistoryDal.Delete(addNewFamilyHistory);
                return new SuccessResult();
            }

            public IDataResult<List<AddNewFamilyHistory>> GetAllByPatientId(string Id)
            {
                return new SuccessDataResult<List<AddNewFamilyHistory>>(addNewFamilyHistoryDal.GetAll(p => p.PatientCode == Id));
            }

            public IDataResult<AddNewFamilyHistory> GetByPatientId(int Id)
            {

                return new SuccessDataResult<AddNewFamilyHistory>(addNewFamilyHistoryDal.Get(p => p.Id == Id));
            }

            public IResult Update(AddNewFamilyHistory addNewFamilyHistory)
            {
                addNewFamilyHistoryDal.Update(addNewFamilyHistory);
                return new SuccessResult();
            }

            public IResult importRecords(string dataFile, string tableName)
            {

                addNewFamilyHistoryDal.importRecords(dataFile, tableName);
                return new SuccessResult();

            }
        }
    }


