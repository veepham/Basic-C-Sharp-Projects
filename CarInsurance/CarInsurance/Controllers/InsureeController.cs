using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public int CalculateQuote()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                int costBase = 50;

                foreach (var insuree in insurees)
                {
                    var today = DateTime.Today;
                    int age = today.Year - insuree.DateofBirth.Year;
                    if (age <= 18)
                    {
                        int ageFee = 100 + costBase;
                        if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                        {
                            int yearA = 25 + ageFee;
                            if (insuree.CarMake == "Porsche")
                            {
                                int makeA = 25 + yearA;
                                if (insuree.CarModel == "911 Carrera")
                                {
                                    int g = 25 + makeA;
                                    int feeTicket = insuree.SpeedingTickets * 10;
                                    int subTotal = g + feeTicket;
                                    if (insuree.DUI == true)
                                    {
                                        double upCharge = 0.25 * subTotal;
                                        int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                        if (insuree.CoverageType == true)
                                        {
                                            double coverFee = 0.5 * feeTotal;
                                            int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                            insuree.Quote = finalTotal;
                                            db.SaveChanges();
                                        }
                                    }
                                    else // no DUI
                                    {
                                        double coverFee = 0.5 * subTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }
                                }
                                else // not 911 carrera
                                {
                                    int feeTicket = insuree.SpeedingTickets * 10;
                                    int subTotal = feeTicket + makeA;
                                    if (insuree.DUI == true)
                                    {
                                        double upCharge = 0.25 * subTotal;
                                        int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                        if (insuree.CoverageType == true)
                                        {
                                            double coverFee = 0.5 * feeTotal;
                                            int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                            insuree.Quote = finalTotal;
                                            db.SaveChanges();
                                        }
                                    }
                                    else // not 911, no dui
                                    {
                                        double coverFee = 0.5 * subTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }

                                }
                            }
                            else //not a porsche but < 2000 and  > 2015
                            {
                                int feeTicket = insuree.SpeedingTickets * 10;
                                int subTotal = feeTicket + yearA;
                                if (insuree.DUI == true)
                                {
                                    double upCharge = 0.25 * subTotal;
                                    int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                    if (insuree.CoverageType == true)
                                    {
                                        double coverFee = 0.5 * feeTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }
                                }
                                else //no dui
                                {
                                    double coverFee = 0.5 * subTotal;
                                    int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                    insuree.Quote = finalTotal;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else // car is between 2000 and 2015
                        {
                            int feeTicket = insuree.SpeedingTickets * 10;
                            int subTotal = feeTicket + ageFee;
                            if (insuree.DUI == true)
                            {
                                double upCharge = 0.25 * subTotal;
                                int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                if (insuree.CoverageType == true)
                                {
                                    double coverFee = 0.5 * feeTotal;
                                    int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                    insuree.Quote = finalTotal;
                                    db.SaveChanges();
                                }
                            }
                            else //no dui
                            {
                                double coverFee = 0.5 * subTotal;
                                int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                insuree.Quote = finalTotal;
                                db.SaveChanges();
                            }
                        }
                    }
                    else if (age > 18 || age < 26)
                    {
                        int ageFee = 50 + costBase;
                        if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                        {
                            int yearA = 25 + ageFee;
                            if (insuree.CarMake == "Porsche")
                            {
                                int makeA = 25 + yearA;
                                if (insuree.CarModel == "911 Carrera")
                                {
                                    int g = 25 + makeA;
                                    int feeTicket = insuree.SpeedingTickets * 10;
                                    int subTotal = g + feeTicket;
                                    if (insuree.DUI == true)
                                    {
                                        double upCharge = 0.25 * subTotal;
                                        int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                        if (insuree.CoverageType == true)
                                        {
                                            double coverFee = 0.5 * feeTotal;
                                            int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                            insuree.Quote = finalTotal;
                                            db.SaveChanges();
                                        }
                                    }
                                    else // no DUI
                                    {
                                        double coverFee = 0.5 * subTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }
                                }
                                else // not 911 carrera
                                {
                                    int feeTicket = insuree.SpeedingTickets * 10;
                                    int subTotal = feeTicket + makeA;
                                    if (insuree.DUI == true)
                                    {
                                        double upCharge = 0.25 * subTotal;
                                        int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                        if (insuree.CoverageType == true)
                                        {
                                            double coverFee = 0.5 * feeTotal;
                                            int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                            insuree.Quote = finalTotal;
                                            db.SaveChanges();
                                        }
                                    }
                                    else // not 911, no dui
                                    {
                                        double coverFee = 0.5 * subTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }

                                }
                            }
                            else //not a porsche but < 2000 and  > 2015
                            {
                                int feeTicket = insuree.SpeedingTickets * 10;
                                int subTotal = feeTicket + yearA;
                                if (insuree.DUI == true)
                                {
                                    double upCharge = 0.25 * subTotal;
                                    int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                    if (insuree.CoverageType == true)
                                    {
                                        double coverFee = 0.5 * feeTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }
                                }
                                else //no dui
                                {
                                    double coverFee = 0.5 * subTotal;
                                    int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                    insuree.Quote = finalTotal;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else // car is between 2000 and 2015
                        {
                            int feeTicket = insuree.SpeedingTickets * 10;
                            int subTotal = feeTicket + ageFee;
                            if (insuree.DUI == true)
                            {
                                double upCharge = 0.25 * subTotal;
                                int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                if (insuree.CoverageType == true)
                                {
                                    double coverFee = 0.5 * feeTotal;
                                    int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                    insuree.Quote = finalTotal;
                                    db.SaveChanges();
                                }
                            }
                            else //no dui
                            {
                                double coverFee = 0.5 * subTotal;
                                int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                insuree.Quote = finalTotal;
                                db.SaveChanges();
                            }
                        }
                    }
                    else // 26 or older
                    {
                        int ageFee = 25 + costBase;
                        if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                        {
                            int yearA = 25 + ageFee;
                            if (insuree.CarMake == "Porsche")
                            {
                                int makeA = 25 + yearA;
                                if (insuree.CarModel == "911 Carrera")
                                {
                                    int g = 25 + makeA;
                                    int feeTicket = insuree.SpeedingTickets * 10;
                                    int subTotal = g + feeTicket;
                                    if (insuree.DUI == true)
                                    {
                                        double upCharge = 0.25 * subTotal;
                                        int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                        if (insuree.CoverageType == true)
                                        {
                                            double coverFee = 0.5 * feeTotal;
                                            int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                            insuree.Quote = finalTotal;
                                            db.SaveChanges();
                                        }
                                    }
                                    else // no DUI
                                    {
                                        double coverFee = 0.5 * subTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }
                                }
                                else // not 911 carrera
                                {
                                    int feeTicket = insuree.SpeedingTickets * 10;
                                    int subTotal = feeTicket + makeA;
                                    if (insuree.DUI == true)
                                    {
                                        double upCharge = 0.25 * subTotal;
                                        int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                        if (insuree.CoverageType == true)
                                        {
                                            double coverFee = 0.5 * feeTotal;
                                            int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                            insuree.Quote = finalTotal;
                                            db.SaveChanges();
                                        }
                                    }
                                    else // not 911, no dui
                                    {
                                        double coverFee = 0.5 * subTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }

                                }
                            }
                            else //not a porsche but < 2000 and  > 2015
                            {
                                int feeTicket = insuree.SpeedingTickets * 10;
                                int subTotal = feeTicket + yearA;
                                if (insuree.DUI == true)
                                {
                                    double upCharge = 0.25 * subTotal;
                                    int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                    if (insuree.CoverageType == true)
                                    {
                                        double coverFee = 0.5 * feeTotal;
                                        int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                        insuree.Quote = finalTotal;
                                        db.SaveChanges();
                                    }
                                }
                                else //no dui
                                {
                                    double coverFee = 0.5 * subTotal;
                                    int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                    insuree.Quote = finalTotal;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else // car is between 2000 and 2015
                        {
                            int feeTicket = insuree.SpeedingTickets * 10;
                            int subTotal = feeTicket + ageFee;
                            if (insuree.DUI == true)
                            {
                                double upCharge = 0.25 * subTotal;
                                int feeTotal = Convert.ToInt32(upCharge) + subTotal;
                                if (insuree.CoverageType == true)
                                {
                                    double coverFee = 0.5 * feeTotal;
                                    int finalTotal = Convert.ToInt32(coverFee) + feeTotal;
                                    insuree.Quote = finalTotal;
                                    db.SaveChanges();
                                }
                            }
                            else //no dui
                            {
                                double coverFee = 0.5 * subTotal;
                                int finalTotal = Convert.ToInt32(coverFee) + subTotal;
                                insuree.Quote = finalTotal;
                                db.SaveChanges();
                            }
                        }
                    }                   

                }

                return ;
            }            
            
        }
    }
}
